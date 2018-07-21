using System;
using System.Collections.Generic;

using Entidades;
using Relatorio.Filtro;

namespace Relatorios.Maperadores
{
	public class FiltroModeloRelatorioMapeador
	{
		public List<FiltroOperadorCondicional> GetOperadores(ModeloRelatorio modelo,  DateTime dtInicial, DateTime dtFinal)
		{
			return new List<FiltroOperadorCondicional>
			{
				new FiltroOperadorCondicional
				{
					Campo = modelo.CampoCodicao01,
					ValorFiltro01 = modelo.ValorCampo01,
					OperadorCondicional = modelo.OperadorCondicional01
				},
				new FiltroOperadorCondicional
				{
					Campo = modelo.CampoCodicao02,
					ValorFiltro01 = modelo.ValorCampo02,
					OperadorCondicional = modelo.OperadorCondicional02
				},
				new FiltroOperadorCondicional
				{
					Campo = modelo.CampoData,
					CampoData = true,
					ValorFiltro01 = dtInicial.ToShortDateString(),
					ValorFiltro02 = dtFinal.ToShortDateString()
				}
			};
		}
	}
}