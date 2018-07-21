using System;
using System.Collections.Generic;
using Entidades;

namespace Relatorios.Modelos
{
	public class RelatorioLayout
	{
		public string Titulo { get; set; }
		public DateTime DataInicial { get; set; }
		public DateTime DataFinal { get; set; }
		public TipoDeImpressao ImprimirCabecalho { get; set; }
		public TipoDeImpressao ImprimirRodape { get; set; }
		public bool ImpimirSumario { get; set; }
		public List<Coluna> ColunasSet { get; set; }
	}
}
