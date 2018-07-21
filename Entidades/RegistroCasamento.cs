using System;
using System.ComponentModel;

namespace Entidades
{
	public class RegistroCasamento : RegistroBase
	{
		[DisplayName("Nome do contraente 01")]
		public string NomeContraente1 { get; set; }

		[DisplayName("Data de nascimento do contraente 01")]
		public DateTime DataNascimentoContraente1 { get; set; }

		[DisplayName("Cidade do contraente 01")]
		public string CidadeContraente1 { get; set; }

		[DisplayName("UF do contraente 01")]
		public string UFContraente1 { get; set; }

		[DisplayName("Nome do contraente 02")]
		public string NomeContraente2 { get; set; }

		[DisplayName("Data de nascimento do contraente 02")]
		public DateTime DataNascimentoContraente2 { get; set; }

		[DisplayName("Cidade do contraente 02")]
		public string CidadeContraente2 { get; set; }

		[DisplayName("UF do contraente 02")]
		public string UFContraente2 { get; set; }
	}
}
