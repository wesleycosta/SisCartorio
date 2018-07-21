using System;
using System.Windows.Forms;

namespace AplicacaoWindowsForm.Helpers
{
	public static class Excecoes
	{
		public static void ExibirExcecoes(Exception ex)
		{
			if (ex is UnauthorizedAccessException)
			{
				ExibirExcecoes("Não foi possível salvar o relatório na pasta do sistema!\n" +
							   "Execute o sistema como administrador!");
			}
			else
			{
				MessageBox.Show(ex.ToString());
			}
		}

		public static void ExibirExcecoes(string ex)
		{
			Mensagens.MostrarMensagem(ex, "Aviso");
		}
	}
}
