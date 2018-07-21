using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AplicacaoWindowsForm.Helpers;
using Entidades;

namespace AplicacaoWindowsForm.Telas.Relatorio
{
	public partial class FrmCadAtributo : Form
	{
		#region PROPRIEDADES E CONSTRUTORES

		public bool Cadastrou { get; internal set; }
		public Atributo Atributo { get; internal set; }

		private readonly Atributo _atributo;
		private readonly ComboBoxHelper _comboBoxHelper = new ComboBoxHelper();
		private readonly TipoDeRegistro _tipoDeRegistro;

		public FrmCadAtributo(TipoDeRegistro tipoDeRegistro, Atributo atributo = null)
		{
			InitializeComponent();

			_atributo = atributo;
			_tipoDeRegistro = tipoDeRegistro;
			_comboBoxHelper.CarregarCampos(ref cbCampo, _tipoDeRegistro);
			cbAlinhamento.SelectedIndex = 0;

			if (_atributo != null)
				CarregarDados();
		}

		#endregion

		#region CARREGAR DADOS

		private void CarregarDados()
		{
			_comboBoxHelper.SelecionarItem(ref cbCampo, _atributo.CampoChave, _tipoDeRegistro);
			tbTitulo.Text = _atributo.Titulo;
			tbTamanho.Value = _atributo.TamanhoColuna;
			cbAlinhamento.SelectedIndex = (int)_atributo.Alinhamento;
		}

		#endregion

		#region AÇÕES

		private void Salvar()
		{
			var erroSet = new List<CampoInvalido>();
			Valida.ValidaCamposObrigatorios(Controls, ref erroSet);

			if (erroSet.Count == 0)
			{
				try
				{
					ConverterParaObjeto();
					Cadastrou = true;
				}
				catch (Exception ex)
				{
					Excecoes.ExibirExcecoes(ex);
				}

				Close();
			}
			else
			{
				Mensagens.MensagemCampoInvalido(erroSet);
			}
		}

		private void ConverterParaObjeto()
		{
			Atributo = new Atributo
			{
				Id = _atributo?.Id ?? 0,
				Titulo = tbTitulo.Text,
				TamanhoColuna = (int)tbTamanho.Value,
				CampoChave = _comboBoxHelper.GetNomeCampo(_tipoDeRegistro, cbCampo.Text),
				Alinhamento = (AlinhamentoColuna)Enum.Parse(typeof(AlinhamentoColuna), cbAlinhamento.SelectedIndex.ToString())
			};
		}


		#endregion

		#region EVENTOS

		private void btnConfirmar_Click(object sender, EventArgs e) => Salvar();

		private void btnCancelar_Click(object sender, EventArgs e) => Close();

		#endregion
	}
}
