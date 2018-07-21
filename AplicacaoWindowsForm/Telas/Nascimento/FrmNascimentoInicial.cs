using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Entidades;
using Repositorio.Implementacoes;

namespace AplicacaoWindowsForm.Telas.Nascimento
{
	using Helpers;

	public partial class FrmNascimentoInicial : Form
	{
		#region PROPRIEDADES

		private List<RegistroNascimento> _registroNascimentoSet;

		#endregion

		#region CONSTRUTORES

		public FrmNascimentoInicial()
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
			var frmCad = new FrmCadNascimento();
			frmCad.ShowDialog();

			if (frmCad.Salvou)
				CarregarDados();
		}

		private void Editar()
		{
			if (lvwDados.SelectedItems.Count > 0)
			{
				var index = lvwDados.SelectedItems[0].Index;
				var registro = _registroNascimentoSet[index];

				var frmCad = new FrmCadNascimento(registro);
				frmCad.ShowDialog();

				if (frmCad.Salvou)
				{
					CarregarDados();
				}
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
					var repositorio = new RepositorioRegistroNascimento();
					var registro = _registroNascimentoSet[index];

					repositorio.Remover(registro);
					lvwDados.Items.RemoveAt(index);
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

			var repositorio = new RepositorioRegistroNascimento();
			_registroNascimentoSet = repositorio.CarregarTodos();

			if (tbPesquisa.Text != string.Empty)
			{
				_registroNascimentoSet = _registroNascimentoSet.
					Where(x => x.NomeRegistrado.Contains(tbPesquisa.Text)).ToList();
			}

			foreach (var registro in _registroNascimentoSet)
			{
				var item = new ListViewItem(registro.NomeRegistrado);
				item.SubItems.Add(registro.DataNascimento.ToShortDateString());
				item.SubItems.Add(registro.NomeDeclarante);
				item.SubItems.Add(registro.NomePai);

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
