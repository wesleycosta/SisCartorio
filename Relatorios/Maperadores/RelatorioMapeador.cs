using Relatorios.Modelos;
using System.Collections.Generic;
using System.Linq;

using Entidades;
using System;

namespace Relatorios.Maperadores
{
	public class RelatorioMapeador
	{
		public RelatorioLayout Mapear<T>(ModeloRelatorio modeloRelatorio, List<T> entidadeSet, DateTime dtInicial, DateTime dtFinal)
		{
			var mapeadorColuna = new ColunaMapeador();

			return new RelatorioLayout
			{
				Titulo = modeloRelatorio.Titulo,
				ImprimirCabecalho = modeloRelatorio.ImprimirCabecalho,
				ImprimirRodape = modeloRelatorio.ImprimirRodape,
				ImpimirSumario = modeloRelatorio.ImprimirSumario,
				DataInicial = dtInicial,
				DataFinal = dtFinal,
				ColunasSet = modeloRelatorio.AtributoSet.Select(a => mapeadorColuna.Mapear(a, entidadeSet)).ToList(),
			};
		}
	}
}
