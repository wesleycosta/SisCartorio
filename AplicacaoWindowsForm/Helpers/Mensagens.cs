using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AplicacaoWindowsForm.Helpers
{
	public class Mensagens
	{
		public static DialogResult DesejaRemover()
		{
			return MessageBox.Show("Tem certeza que deseja remover esse registro?", "Aviso",
									MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		public static void SelecioneUmaLinha()
		{
			MostrarMensagem("Por favor, selecione uma linha da tabela.", "Aviso");
		}

		public static void MensagemCampoInvalido(List<CampoInvalido> erroSet)
		{
			var campos = string.Join(";\n", erroSet.OrderBy(x => x.Index).
											Select(x => x.Descricao).ToArray());

			MostrarMensagem($"Por favor, preecha o(s) campo(s):\n{campos}.", "Aviso");
		}

		public static void MostrarMensagem(string texto, string titulo)
		{
			MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static void GravadoComSucesso()
		{
			MostrarMensagem("Gravado com sucesso", "Aviso");
		}
	}
}
