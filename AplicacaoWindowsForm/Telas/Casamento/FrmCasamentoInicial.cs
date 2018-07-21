using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Entidades;
using Repositorio.Implementacoes;

namespace AplicacaoWindowsForm.Telas.Casamento
{
	using Helpers;

	public partial class FrmCasamentoInicial : Form
	{
		#region PROPRIEDADES

		private List<RegistroCasamento> _registroCasamentoSet;

		#endregion

		#region CONSTRUTORES

		public FrmCasamentoInicial()
		{
			InitializeComponent();
			AdicionarEventos();
		}

		private void AdicionarEventos()
		{
			Load += (o, a) => CarregarDados();
			tbPesquisa.KeyUp += (o, a) => CarregarDados();
			lvwDados.DoubleClick += (o, a) => Editar();
		}

		#endregion

		#region AÇÕES

		private void Cadastrar()
		{
			var frmCad = new FrmCadCasamento();
			frmCad.ShowDialog();

			if (frmCad.Salvou)
				CarregarDados();
		}

		private void Editar()
		{
			if (lvwDados.SelectedItems.Count > 0)
			{
				var index = lvwDados.SelectedItems[0].Index;
				var registro = _registroCasamentoSet[index];

				var frmCad = new FrmCadCasamento(registro);
				frmCad.ShowDialog();

				if (frmCad.Salvou)
					CarregarDados();
			}
			else
				Mensagens.SelecioneUmaLinha();
		}

		private void Remover()
		{
			if (lvwDados.SelectedItems.Count > 0)
			{
				var r = Mensagens.DesejaRemover();
				if (r != DialogResult.Yes) return;

				var index = lvwDados.SelectedItems[0].Index;
				var repositorio = new RepositorioRegistroCasamento();
				var registro = _registroCasamentoSet[index];

				repositorio.Remover(registro);
				lvwDados.Items.RemoveAt(index);
			}
			else
				Mensagens.SelecioneUmaLinha();
		}

		private void CarregarDados()
		{
			lvwDados.Items.Clear();

			var repositorio = new RepositorioRegistroCasamento();
			_registroCasamentoSet = repositorio.CarregarTodos();

			if (tbPesquisa.Text != string.Empty)
			{
				_registroCasamentoSet = _registroCasamentoSet.
					Where(x => x.NomeContraente1.Contains(tbPesquisa.Text) ||
							   x.NomeContraente2.Contains(tbPesquisa.Text)).ToList();
			}

			foreach (var registro in _registroCasamentoSet)
			{
				var item = new ListViewItem(registro.NomeContraente1);
				item.SubItems.Add(registro.NomeContraente2);
				item.SubItems.Add(registro.DataNascimentoContraente1.ToShortDateString());
				item.SubItems.Add(registro.DataNascimentoContraente2.ToShortDateString());
				item.SubItems.Add(registro.DataRegistro.ToShortDateString());

				lvwDados.Items.Add(item);
			}
		}

		#endregion

		#region EVENTOS

		private void Cadastrar_Click(object sender, EventArgs e) => Cadastrar();

		private void pbEditar_Click(object sender, EventArgs e) => Editar();

		private void pbRemover_Click(object sender, EventArgs e) => Remover();

		#endregion
	}
}
