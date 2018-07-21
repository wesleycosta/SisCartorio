using System;
using System.ComponentModel;

namespace Entidades
{
	public class RegistroNascimento : RegistroBase
	{
		[DisplayName("Nome registrado")]
		public string NomeRegistrado { get; set; }

		[DisplayName("Data de nascimento")]
		public DateTime DataNascimento { get; set; }

		[DisplayName("Código do declarante")]
		public char CodigoDeclarante { get; set; }

		[DisplayName("Nome do declarante")]
		public string NomeDeclarante { get; set; }

		[DisplayName("Nome pai")]
		public string NomePai { get; set; }

		[DisplayName("Idade do pai")]
		public int IdadePai { get; set; }

		[DisplayName("Nome da mãe")]
		public string NomeMae { get; set; }

		[DisplayName("Cidade")]
		public string Cidade { get; set; }

		[DisplayName("UF")]
		public string UF { get; set; }
	}
}
