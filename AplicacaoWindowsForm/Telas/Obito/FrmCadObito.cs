using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AplicacaoWindowsForm.Telas.Obito
{
	using Helpers;
	using Entidades;
	using Repositorio.Implementacoes;

	public partial class FrmCadObito : Form
	{
		#region PROPRIEDADES

		public bool Salvou { get; set; }

		private readonly RegistroObito _registroObito;

		#endregion

		#region CONSTRUTORES 

		public FrmCadObito()
		{
			InitializeComponent();
			cbEleitor.SelectedIndex = cbReservista.SelectedIndex = 0;
			AdicionarValidacoes();
		}

		public FrmCadObito(RegistroObito registroObito)
		{
			_registroObito = registroObito;
			InitializeComponent();
			AdicionarValidacoes();
			Carregar();
		}

		private void AdicionarValidacoes()
		{
			tbNumeroFolha.KeyPress += Valida.Naturais_KeyPress;
			tbNumeroLivro.KeyPress += Valida.Naturais_KeyPress;
			tbNumeroRegistro.KeyPress += Valida.Naturais_KeyPress;
		}

		#endregion

		#region MANTEM DADOS

		private void Carregar()
		{
			tbNomeLivro.Text = _registroObito.NomeLivro;
			tbNumeroFolha.Text = _registroObito.NumeroFolha.ToString();
			tbNumeroLivro.Text = _registroObito.NumeroLivro.ToString();
			tbNumeroRegistro.Text = _registroObito.NumeroRegistro.ToString();
			tbPosicaoFolha.Text = _registroObito.PosicaoFolha.ToString();

			tbNomeFalecido.Text = _registroObito.NomeFalecido;
			tbDataFalecimento.Value = _registroObito.DataFalecimento;
			cbEleitor.SelectedIndex = _registroObito.Eleitor ? 1 : 0;
			cbReservista.SelectedIndex = _registroObito.Reservista ? 1 : 0;
			tbNomeDeclarante.Text = _registroObito.NomeDeclarante;
			tbNomeMae.Text = _registroObito.NomeMae;
			tbNomePai.Text = _registroObito.NomePai;
			tbCidade.Text = _registroObito.Cidade;
			tbUF.Text = _registroObito.UF;
		}

		private RegistroObito ConveterParaObjeto()
		{
			return new RegistroObito
			{
				Id = _registroObito?.Id ?? 0,
				NomeLivro = tbNomeLivro.Text,
				NumeroFolha = int.Parse(tbNumeroFolha.Text),
				NumeroLivro = int.Parse(tbNumeroLivro.Text),
				NumeroRegistro = int.Parse(tbNumeroRegistro.Text),
				PosicaoFolha = char.Parse(tbPosicaoFolha.Text),
				NomeFalecido = tbNomeFalecido.Text,
				NomeMae = tbNomeMae.Text,
				NomePai = tbNomePai.Text,
				NomeDeclarante = tbNomeDeclarante.Text,
				DataFalecimento = tbDataFalecimento.Value,
				Eleitor = cbEleitor.SelectedIndex == 1,
				Reservista = cbReservista.SelectedIndex == 1,
				Cidade = tbCidade.Text,
				UF = tbUF.Text
			};
		}

		private void MantemDados()
		{
			var entidade = ConveterParaObjeto();
			var repositorio = new RepositorioRegistroObito();
			repositorio.Salvar(entidade);
		}

		private void Salvar()
		{
			var erroSet = new List<CampoInvalido>();
			Valida.ValidaCamposObrigatorios(Controls, ref erroSet);

			if (erroSet.Count == 0)
			{
				try
				{
					MantemDados();
					Mensagens.GravadoComSucesso();
					Salvou = true;
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

		private void btnSalvar_Click(object sender, EventArgs e) => Salvar();

		private void btnCancelar_Click(object sender, EventArgs e) => Close();

		#endregion
	}
}
