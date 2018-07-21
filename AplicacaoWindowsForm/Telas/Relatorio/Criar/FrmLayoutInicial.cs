using System.Collections.Generic;
using System.Windows.Forms;
using System;

using Entidades;
using Repositorio.Implementacoes;

namespace AplicacaoWindowsForm.Telas.Relatorio
{
	using Helpers;

	public partial class FrmDefinirLayout : Form
	{
		#region PROPRIEDADES E CONSTRUTORES

		private readonly ModeloRelatorio _modelo;
		private List<Atributo> _atributoSet;

		public FrmDefinirLayout(ModeloRelatorio modelo)
		{
			_atributoSet = new List<Atributo>();
			_modelo = modelo;

			InitializeComponent();

			if (modelo.Id > 0)
				IniciarDados();
		}

		#endregion

		#region CARREGAR DADOS

		private void IniciarDados()
		{
			var repositorio = new RepositorioAbtributo();
			_atributoSet = repositorio.CarregarPorIdModeloRelatorio(_modelo.Id);

			CarregarDados();
		}

		private void CarregarDados()
		{
			lvwDados.Items.Clear();

			foreach (var atributo in _atributoSet)
			{
				var item = new ListViewItem(atributo.Titulo);
				var tamanhoColuna = new ListViewItem.ListViewSubItem {Text = atributo.TamanhoColuna.ToString()};

				item.SubItems.Add(tamanhoColuna);

				lvwDados.Items.Add(item);
			}

			SetLabel();
		}

		private void SetLabel()
		{
			lbTotal.Text = $"TOTAL DE COLUNAS:  {_atributoSet.Count:D2}";
		}

		#endregion

		#region AÇÕES

		private void Adicionar()
		{
			var frmCadAtributo = new FrmCadAtributo(_modelo.TipoDeRegistro);
			frmCadAtributo.ShowDialog();

			if (frmCadAtributo.Cadastrou)
			{
				_atributoSet.Add(frmCadAtributo.Atributo);
				CarregarDados();
			}
		}

		private void Editar()
		{
			if (lvwDados.SelectedItems.Count > 0)
			{
				var index = lvwDados.SelectedItems[0].Index;
				var registro = _atributoSet[index];

				var frmCad = new FrmCadAtributo(_modelo.TipoDeRegistro, registro);
				frmCad.ShowDialog();

				if (frmCad.Cadastrou)
				{
					_atributoSet[index] = frmCad.Atributo;
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
					var atributo = _atributoSet[index];

					_atributoSet.RemoveAt(index);
					lvwDados.Items.RemoveAt(index);
					SetLabel();

					if(atributo.Id > 0)
					{
						var repositorio = new RepositorioAbtributo();
						repositorio.Remover(atributo);
					}
				}
			}
			else
			{
				Mensagens.SelecioneUmaLinha();
			}
		}

		private void Salvar()
		{
			if (_atributoSet.Count == 0)
			{
				Mensagens.MostrarMensagem("Por favor, adicione uma coluna!", "Aviso");
				return;
			}

			var repositorio = new RepositorioModeloRelatorio();

			repositorio.Salvar(_modelo, _atributoSet);
			Close();
		}

		#endregion

		#region EVENTOS

		private void Adicionar_Click(object sender, EventArgs e) => Adicionar();
		private void Editar_Click(object sender, EventArgs e) => Editar();

		private void Remover_Click(object sender, EventArgs e) => Remover();

		private void btnSalvar_Click(object sender, EventArgs e) => Salvar();

		private void btnCancelar_Click(object sender, EventArgs e) => Close();
		private void lvwDados_DoubleClick(object sender, EventArgs e) => Editar();

		#endregion
	}
}
