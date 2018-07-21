using AplicacaoWindowsForm.Helpers;
using Entidades;
using Relatorios;
using System;
using System.Windows.Forms;

namespace AplicacaoWindowsForm.Telas.Relatorio.Modelos
{
	public partial class FrmFiltrarRelatorio : Form
	{
		#region PROPRIEDADES E CONSTRUTORES

		private readonly ModeloRelatorio _modeloRelatorio;

		public FrmFiltrarRelatorio(ModeloRelatorio modelo)
		{
			InitializeComponent();
			_modeloRelatorio = modelo;
		}

		#endregion

		#region AÇÕES

		public void GerarRelatorio()
		{
			try
			{
				var servico = new ServicoRelatorio();
				servico.GerarRelatorio(_modeloRelatorio, tbDataInicial.Value, tbDataFinal.Value);
			}
			catch (Exception ex)
			{
				Excecoes.ExibirExcecoes(ex);
			}
		}

		#endregion

		#region EVENTOS

		private void btnConfirmar_Click(object sender, EventArgs e) => GerarRelatorio();

		private void btnCancelar_Click(object sender, EventArgs e) => Close();

		#endregion
	}
}
