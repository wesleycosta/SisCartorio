using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Entidades;
using Repositorio.Implementacoes;

namespace AplicacaoWindowsForm.Telas.Relatorio.Criar
{
	using Helpers;

	public partial class FrmCriarRelatorioInicial : Form
	{
		#region PROPRIEDADES

		private List<ModeloRelatorio> _modeloRelatorioSet;

		#endregion

		#region CONSTRUTORES

		public FrmCriarRelatorioInicial()
		{
			InitializeComponent();
			AdicionarEventos();
		}

		private void AdicionarEventos()
		{
			Load += (o, a) => CarregarDados();
		}

		private void SetTotal()
		{
			lbTotal.Text = $"TOTAL: {_modeloRelatorioSet.Count:D2}";
		}

		#endregion

		#region AÇÕES

		private void Cadastrar()
		{
			var frmCad = new FrmCadModeloRelatorio();
			frmCad.ShowDialog();

			if (frmCad.Salvou)
				CarregarDados();
		}

		private void Editar()
		{
			if (lvwDados.SelectedItems.Count > 0)
			{
				var index = lvwDados.SelectedItems[0].Index;
				var modelo = _modeloRelatorioSet[index];

				var frmCad = new FrmCadModeloRelatorio(modelo);
				frmCad.ShowDialog();

				if (frmCad.Salvou)
					CarregarDados();
			}
			else
			{
				Mensagens.SelecioneUmaLinha();
			}
		}

		private void Remover()
		{
			if (lvwDados.SelectedItems.Count > 0)
			{
				var r = Mensagens.DesejaRemover();
				if (r == DialogResult.Yes)
				{
					var index = lvwDados.SelectedItems[0].Index;
					var repositorio = new RepositorioModeloRelatorio();
					var registro = _modeloRelatorioSet[index];

					repositorio.Remover(registro);
					lvwDados.Items.RemoveAt(index);
					SetTotal();
				}
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
			_modeloRelatorioSet = repositorio.CarregarTodos();

			_modeloRelatorioSet.ForEach(x => lvwDados.Items.Add(x.Titulo));
			SetTotal();
		}

		#endregion

		#region EVENTOS

		private void Cadastrar_Click(object sender, EventArgs e) => Cadastrar();
		private void Editar_Click(object sender, EventArgs e) => Editar();

		private void pbRemover_Click(object sender, EventArgs e) => Remover();
		private void lvwDados_DoubleClick(object sender, EventArgs e) => Editar();

		#endregion
	}
}
