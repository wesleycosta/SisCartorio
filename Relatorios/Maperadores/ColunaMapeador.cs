using System.Linq;
using System.Collections.Generic;

using Entidades;

namespace Relatorios.Maperadores
{
	using Modelos;
	using Relatorio.Filtro;

	public class ColunaMapeador
	{
		public Coluna Mapear<T>(Atributo atributo, List<T> entidadeSet)
		{
			var filtro = new Filtro();

			return new Coluna
			{
				Titulo = atributo.Titulo,
				TamanhoColuna = atributo.TamanhoColuna,
				Alinhamento = atributo.Alinhamento,
				LinhasSet = entidadeSet.Select(x =>
					filtro.GetValorDaPropeidade(x, atributo.CampoChave).ToString()).ToList()
			};
		}
	}
}
