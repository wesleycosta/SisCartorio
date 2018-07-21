using System;
using System.ComponentModel;

namespace Entidades
{
	public abstract class RegistroBase
	{
		[DisplayName("Código do registro")]
		public int Id { get; set; }

		[DisplayName("Nome do livro")]
		public string NomeLivro { get; set; }

		[DisplayName("Número do livro")]
		public int NumeroLivro { get; set; }

		[DisplayName("Número da folha")]
		public int NumeroFolha { get; set; }

		[DisplayName("Posição folha")]
		public char PosicaoFolha { get; set; }

		[DisplayName("Número do registro")]
		public int NumeroRegistro { get; set; }

		[DisplayNameAttribute("Data de registro")]
		public DateTime DataRegistro { get; set; } = DateTime.Now;
	}
}
