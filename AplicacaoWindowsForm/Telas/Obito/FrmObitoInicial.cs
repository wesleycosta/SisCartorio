using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Entidades;
using Repositorio.Implementacoes;

namespace AplicacaoWindowsForm.Telas.Obito
{
	using Helpers;

	public partial class FrmObitoInicial : Form
	{
		#region PROPRIEDADES

		private List<RegistroObito> _registroObitoSet;

		#endregion

		#region CONSTRUTORES

		public FrmObitoInicial()
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
			var frmCad = new FrmCadObito();
			frmCad.ShowDialog();

			if (frmCad.Salvou)
				CarregarDados();
		}

		private void Editar()
		{
			if (lvwDados.SelectedItems.Count > 0)
			{
				var index = lvwDados.SelectedItems[0].Index;
				var registro = _registroObitoSet[index];

				var frmCad = new FrmCadObito(registro);
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
					var repositorio = new RepositorioRegistroObito();
					var registro = _registroObitoSet[index];

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

			var repositorio = new RepositorioRegistroObito();
			_registroObitoSet = repositorio.CarregarTodos();

			if (tbPesquisa.Text != string.Empty)
			{
				_registroObitoSet = _registroObitoSet.
					Where(x => x.NomeFalecido.Contains(tbPesquisa.Text)).ToList();
			}

			foreach (var registro in _registroObitoSet)
			{
				var item = new ListViewItem(registro.NomeFalecido);
				item.SubItems.Add(registro.DataFalecimento.ToShortDateString());
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
