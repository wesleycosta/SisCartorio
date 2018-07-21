using System.Collections.Generic;

namespace Entidades
{
	public class ModeloRelatorio
	{
		public int Id { get; set; }
		public string Titulo { get; set; }
		public TipoDeRegistro TipoDeRegistro { get; set; }
		public string CampoData { get; set; }
		public bool AplicarCondicao { get; set; }

		public string CampoCodicao01 { get; set; }
		public OperadorCondicional OperadorCondicional01 { get; set; }
		public string ValorCampo01 { get; set; }

		public OperadorLogico OperadorLogico;

		public string CampoCodicao02 { get; set; }
		public OperadorCondicional OperadorCondicional02 { get; set; }
		public string ValorCampo02 { get; set; }

		public TipoDeImpressao ImprimirCabecalho { get; set; }
		public TipoDeImpressao ImprimirRodape { get; set; }
		public bool ImprimirSumario { get; set; }

		public List<Atributo> AtributoSet { get; set; }
	}
}
