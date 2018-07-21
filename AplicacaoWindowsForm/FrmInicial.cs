using System;
using System.Windows.Forms;


namespace AplicacaoWindowsForm
{
	using Telas.Obito;
	using Telas.Casamento;
	using Telas.Nascimento;
	using Telas.Relatorio.Criar;
	using AplicacaoWindowsForm.Telas.Relatorio.Modelos;

	public partial class FrmInicial : Form
	{
		public FrmInicial()
		{
			InitializeComponent();


		}

		#region EVENTO CLICK

		private void Nascimento_Click(object sender, EventArgs e) =>
			new FrmNascimentoInicial().ShowDialog();

		private void Casamento_Click(object sender, EventArgs e) =>
			new FrmCasamentoInicial().ShowDialog();

		private void Obito_Click(object sender, EventArgs e) =>
			new FrmObitoInicial().ShowDialog();

		private void CriarRelatorio_Click(object sender, EventArgs e) =>
			new FrmCriarRelatorioInicial().ShowDialog();

		private void Relatorio_Click(object sender, EventArgs e) =>
			new FrmRelatoriosModelos().ShowDialog();

		#endregion
	}
}
