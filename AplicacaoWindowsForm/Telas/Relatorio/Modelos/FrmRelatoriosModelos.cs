using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Entidades;
using Repositorio.Implementacoes;

namespace AplicacaoWindowsForm.Telas.Relatorio.Modelos
{
	using Helpers;

	public partial class FrmRelatoriosModelos : Form
	{
		#region PROPRIEDADES

		private List<ModeloRelatorio> modeloRelatorioSet;

		#endregion

		#region CONSTRUTORES

		public FrmRelatoriosModelos()
		{
			InitializeComponent();
			AdicionarEventos();
		}

		private void AdicionarEventos()
		{
			Load += (o, a) => CarregarDados();
			lvwDados.DoubleClick += (o, a) => Selecionar();
		}

		#endregion

		#region AÇÕES

		private void Selecionar()
		{
			if (lvwDados.SelectedItems.Count > 0)
			{
				var index = lvwDados.SelectedItems[0].Index;
				var modelo = modeloRelatorioSet[index];

				var frmFiltro = new FrmFiltrarRelatorio(modelo);
				frmFiltro.ShowDialog();
			}
			else
			{
				Mensagens.SelecioneUmaLinha();
			}
		}

		private void CarregarDados()
		{
			lvwDados.Items.Clear();

			var repositorio = new RepositorioModeloRelatorio();
			modeloRelatorioSet = repositorio.CarregarTodos();

			modeloRelatorioSet.ForEach(x =>
				lvwDados.Items.Add(new ListViewItem(x.Titulo)));
		}

		#endregion

		#region EVENTOS

		private void btnConfirmar_Click(object sender, EventArgs e) => Selecionar();

		private void btnCancelar_Click(object sender, EventArgs e) => Close();

		#endregion
	}
}
