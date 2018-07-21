using Entidades;
using Relatorio.Filtro;
using Relatorios.Maperadores;
using System;
using System.Collections.Generic;

namespace Relatorios
{
	public class FiltroDados<T>
	{
		public List<T> FiltrarRegistros(ModeloRelatorio modelo, List<T> entidadeSet, DateTime dtInicial, DateTime dtFinal)
		{
			var filtro = new Filtro();
			var modeloMapeador = new FiltroModeloRelatorioMapeador();
			var operador = modeloMapeador.GetOperadores(modelo, dtInicial, dtFinal);

			return filtro.Filtrar(operador, modelo, entidadeSet, dtInicial, dtFinal);
		}
	}
}
