using System;
using System.Windows.Forms;

using Entidades;

namespace AplicacaoWindowsForm.Telas.Relatorio
{
	using Helpers;
	using System.Collections.Generic;

	public partial class FrmCadModeloRelatorio : Form
	{
		#region PROPRIEDADES E CONSTRUTORES

		public bool Salvou { get; set; }

		private readonly ModeloRelatorio _modelo;
		private readonly ComboBoxHelper _comboBoxHelper;
		private TipoDeRegistro _tipoDeRegistro =>
			(TipoDeRegistro)Enum.Parse(typeof(TipoDeRegistro), cbTipoDeRegistro.SelectedIndex.ToString());

		public FrmCadModeloRelatorio(ModeloRelatorio modelo = null)
		{
			_modelo = modelo;
			_comboBoxHelper = new ComboBoxHelper();

			InitializeComponent();
			IniciarCombo();
			Load += (o, a) =>
			{
				cbAplicarCondicao.SelectedIndex = 1;
				cbTipoDeRegistro.SelectedIndex = 0;

				if (modelo != null)
					CarregarDados();
			};
		}

		private void IniciarCombo()
		{
			cbAplicarCondicao.SelectedIndex = 0;
			cbOperadorCondicional01.SelectedIndex = 0;
			cbOperadorLogico.SelectedIndex = 0;
			cbOperadorCondicional02.SelectedIndex = 0;
			cbImprimirCabecalho.SelectedIndex = 0;
			cbImprimirRodape.SelectedIndex = 0;
			cbImprimirSumario.SelectedIndex = 0;
		}

		#endregion

		#region CARREGAR DADOS

		private void CarregarDados()
		{
			tbTitulo.Text = _modelo.Titulo;
			cbTipoDeRegistro.SelectedIndex = (int)_modelo.TipoDeRegistro;
			_comboBoxHelper.SelecionarItem(ref cbCampoData, _modelo.CampoData, _tipoDeRegistro, true);
			cbAplicarCondicao.SelectedIndex = _modelo.AplicarCondicao ? 0 : 1;

			_comboBoxHelper.SelecionarItem(ref cbCampoCondicional01, _modelo.CampoCodicao01, _tipoDeRegistro);
			cbOperadorCondicional01.SelectedIndex = (int)_modelo.OperadorCondicional01;
			tbValorCondicional01.Text = _modelo.ValorCampo01;
			cbOperadorLogico.SelectedIndex = (int)_modelo.OperadorLogico;

			_comboBoxHelper.SelecionarItem(ref cbCampoCondicional02, _modelo.CampoCodicao02, _tipoDeRegistro);
			cbOperadorCondicional02.SelectedIndex = (int)_modelo.OperadorCondicional02;
			tbValorCondicional02.Text = _modelo.ValorCampo02;

			cbImprimirCabecalho.SelectedIndex = (int)_modelo.ImprimirCabecalho;
			cbImprimirRodape.SelectedIndex = (int)_modelo.ImprimirRodape;
			cbImprimirSumario.SelectedIndex = _modelo.ImprimirSumario ? 0 : 1;
		}

		#endregion

		#region MANTEM DADOS

		private ModeloRelatorio ConveterParaObjeto()
		{
			return new ModeloRelatorio
			{
				Id = _modelo?.Id ?? 0,
				Titulo = tbTitulo.Text,
				TipoDeRegistro = _tipoDeRegistro,
				CampoData = _comboBoxHelper.GetNomeCampo(_tipoDeRegistro, cbCampoData.Text, true),
				AplicarCondicao = cbAplicarCondicao.SelectedIndex == 0,
				CampoCodicao01 = _comboBoxHelper.GetNomeCampo(_tipoDeRegistro, cbCampoCondicional01.Text),
				CampoCodicao02 = _comboBoxHelper.GetNomeCampo(_tipoDeRegistro, cbCampoCondicional02.Text),
				OperadorCondicional01 = (OperadorCondicional)Enum.Parse(typeof(OperadorCondicional), cbOperadorCondicional01.SelectedIndex.ToString()),
				OperadorCondicional02 = (OperadorCondicional)Enum.Parse(typeof(OperadorCondicional), cbOperadorCondicional02.SelectedIndex.ToString()),
				OperadorLogico = (OperadorLogico)Enum.Parse(typeof(OperadorLogico), cbOperadorLogico.SelectedIndex.ToString()),
				ValorCampo01 = tbValorCondicional01.Text,
				ValorCampo02 = tbValorCondicional02.Text,
				ImprimirCabecalho = (TipoDeImpressao)Enum.Parse(typeof(TipoDeImpressao), cbImprimirCabecalho.SelectedIndex.ToString()),
				ImprimirRodape = (TipoDeImpressao)Enum.Parse(typeof(TipoDeImpressao), cbImprimirRodape.SelectedIndex.ToString()),
				ImprimirSumario = cbImprimirSumario.SelectedIndex == 0
			};
		}

		#endregion

		#region AÇÕES

		private void Confirmar()
		{
			var erroSet = new List<CampoInvalido>();
			Valida.ValidaCamposObrigatorios(Controls, ref erroSet);

			if (erroSet.Count == 0)
			{
				try
				{
					var modelo = ConveterParaObjeto();
					var frmDefinir = new FrmDefinirLayout(modelo);
					frmDefinir.ShowDialog();
					Salvou = true;
					Close();
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

		#endregion

		#region EVENTOS

		private void btnConfirmar_Click(object sender, EventArgs e) => Confirmar();

		private void btnCancelar_Click(object sender, EventArgs e) => Close();

		private void cbAplicarCondicao_SelectedIndexChanged(object sender, EventArgs e) =>
			gbCondicao.Enabled = cbAplicarCondicao.SelectedIndex == 0;

		private void cbTipoDeRegistro_SelectedIndexChanged(object sender, EventArgs e) =>
			_comboBoxHelper.CarregarCampos(ref cbCampoData, ref cbCampoCondicional01, ref cbCampoCondicional02, _tipoDeRegistro);

		private void cbOperadorLogico_SelectedIndexChanged(object sender, EventArgs e) =>
			pnCondicao02.Visible = cbOperadorLogico.SelectedIndex > 0;

		#endregion
	}
}
