using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;

using Entidades;

namespace Relatorio.Filtro
{
	public class Filtro
	{
		#region  FILTRO PARA PROPRIEDADES DAS ENTIDADES

		public List<FiltroDescricao> GetPropriedadesTipoData<T>(bool apenasTipoData, bool trazerTipoData = false)
		{
			return apenasTipoData ? GetPropriedadesTipoData<T>() : GetPropriedades<T>(trazerTipoData);
		}

		public List<FiltroDescricao> GetPropriedadesTipoData<T>()
		{
			var t = typeof(T);
			var propInfos = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);

			return propInfos.
				Where(x => x.PropertyType == Type.GetType(typeof(DateTime).ToString())).
				Select(z => new FiltroDescricao
				{
					NomeDoCampo = z.Name,
					Descricao = ((DisplayNameAttribute)z.GetCustomAttribute(typeof(DisplayNameAttribute))).DisplayName,
				}).OrderBy(x => x.Descricao).ToList();
		}

		public List<FiltroDescricao> GetPropriedades<T>(bool trazerTipoData = false)
		{
			var t = typeof(T);
			var propInfos = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);

			return propInfos.
				Where(x => x.PropertyType != Type.GetType(typeof(DateTime).ToString()) || trazerTipoData).
				Select(z => new FiltroDescricao
				{
					NomeDoCampo = z.Name,
					Descricao = ((DisplayNameAttribute)z.GetCustomAttribute(typeof(DisplayNameAttribute))).DisplayName,
				}).OrderBy(x => x.Descricao).ToList();
		}

		public object GetValorDaPropeidade(object entidade, string campo)
		{
			return entidade.GetType().GetProperty(campo)?.GetValue(entidade, null);
		}

		#endregion

		#region APLICAR FILTRO DE DADOS

		public List<T> Filtrar<T>(List<FiltroOperadorCondicional> filtroOperadorCondicionalSet, ModeloRelatorio modelo,
								  IEnumerable<T> entidadeSet, DateTime dtInicial, DateTime dtFinal)
		{
			var retornoSet = new List<T>();

			var filtroData = filtroOperadorCondicionalSet.FirstOrDefault(x => x.CampoData);
			filtroOperadorCondicionalSet.Remove(filtroData);
			entidadeSet = Filtrar(filtroData, entidadeSet);

			if (!modelo.AplicarCondicao)
			{
				return entidadeSet.ToList();
			}

			foreach (var filtro in filtroOperadorCondicionalSet)
			{
				var retornoFiltro = Filtrar(filtro, entidadeSet);

				if (modelo.OperadorLogico == OperadorLogico.E && retornoSet.Count > 0)
				{
					var diferencaSet = retornoSet.Except(retornoFiltro).ToList();
					diferencaSet.ForEach(x => retornoFiltro.Remove(x));
					
					if (diferencaSet.Count > 0)
						retornoSet.Clear();
				}

				retornoFiltro.ForEach(x => retornoSet.Add(x));
				retornoSet = retornoSet.Distinct().ToList();

				if (modelo.OperadorLogico == OperadorLogico.Nenhum)
					return retornoSet.ToList();
			}

			return retornoSet.ToList();
		}

		private List<T> Filtrar<T>(FiltroOperadorCondicional filtro, IEnumerable<T> entidadeSet)
		{
			PropertyInfo info = typeof(T).GetProperty(filtro.Campo);

			return entidadeSet
			  .Select(item => new
			  {
				  value = item,
				  prop = info.GetValue(item),
			  })
			  .Where(item => filtro.ValorFiltro01 == null
				 ? item.prop == null
				 : item.prop != null && AplicarOperadorCondicional(filtro, item.prop.ToString()))
			  .Select(item => item.value)
			  .ToList();
		}

		private bool AplicarOperadorCondicional(FiltroOperadorCondicional filtro, string valorEntidade)
		{
			var valorFiltro = filtro.ValorFiltro01;
			var operador = filtro.OperadorCondicional;

			if (filtro.CampoData)
			{
				var dtInicio = DateTime.Parse(filtro.ValorFiltro01);
				var dtFinal = DateTime.Parse(filtro.ValorFiltro02);
				var dtEntidade = DateTime.Parse(valorEntidade);

				return dtEntidade.Date >= dtInicio.Date &&
					   dtEntidade.Date <= dtFinal.Date;
			}

			if (!EhNumero(valorFiltro, valorEntidade) &&
				operador != OperadorCondicional.IgualA &&
				operador != OperadorCondicional.DiferenteDe)
				return false;

			switch (operador)
			{
				case OperadorCondicional.IgualA:
					return string.Equals(valorFiltro, valorEntidade);
				case OperadorCondicional.DiferenteDe:
					return !string.Equals(valorFiltro, valorEntidade);
				case OperadorCondicional.MaiorOuIgualA:
					return double.Parse(valorEntidade) >= double.Parse(valorFiltro);
				case OperadorCondicional.MaiorQue:
					return double.Parse(valorEntidade) > double.Parse(valorFiltro);
				case OperadorCondicional.MenorOuIgualA:
					return double.Parse(valorEntidade) <= double.Parse(valorFiltro);
				case OperadorCondicional.MenorQue:
					return double.Parse(valorEntidade) < double.Parse(valorFiltro);
			}

			return false;
		}

		private bool EhNumero(string valorFiltro, string valorEntidade)
		{
			var osDoisSaoNumeros = double.TryParse(valorEntidade, out _);

			return osDoisSaoNumeros;
		}

		#endregion
	}
}