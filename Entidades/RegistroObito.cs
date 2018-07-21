using System;
using System.ComponentModel;

namespace Entidades
{
	public class RegistroObito : RegistroBase
	{
		[DisplayName("Nome do falecido")]
		public string NomeFalecido { get; set; }

		[DisplayName("Data de falecimento")]
		public DateTime DataFalecimento { get; set; }

		[DisplayName("Eleitor")]
		public bool Eleitor { get; set; }

		[DisplayName("Reservista")]
		public bool Reservista { get; set; }

		[DisplayName("Nome do declarante")]
		public string NomeDeclarante { get; set; }

		[DisplayName("Nome do pai")]
		public string NomePai { get; set; }

		[DisplayName("Nome da mãe")]
		public string NomeMae { get; set; }

		[DisplayName("Cidade")]
		public string Cidade { get; set; }

		[DisplayName("UF")]
		public string UF { get; set; }
	}
}
