using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AplicacaoWindowsForm.Telas.Nascimento
{
	using Helpers;
	using Entidades;
	using Repositorio.Implementacoes;

	public partial class FrmCadNascimento : Form
	{
		#region PROPRIEDADES

		public bool Salvou { get; set; }

		private readonly RegistroNascimento _registroNascimento;

		#endregion

		#region CONSTRUTORES 

		public FrmCadNascimento()
		{
			InitializeComponent();
			AdicionarValidacoes();
		}

		public FrmCadNascimento(RegistroNascimento registroNascimento)
		{
			_registroNascimento = registroNascimento;
			InitializeComponent();
			AdicionarValidacoes();
			Carregar();
		}

		private void AdicionarValidacoes()
		{
			tbNumeroFolha.KeyPress += Valida.Naturais_KeyPress;
			tbNumeroLivro.KeyPress += Valida.Naturais_KeyPress;
			tbNumeroRegistro.KeyPress += Valida.Naturais_KeyPress;
			tbIdadePai.KeyPress += Valida.Naturais_KeyPress;
		}

		#endregion

		#region MANTEM DADOS

		private void Carregar()
		{
			tbCidade.Text = _registroNascimento.Cidade;
			tbCodigoDeclarante.Text = _registroNascimento.CodigoDeclarante.ToString();
			tbDataNascimento.Value = _registroNascimento.DataNascimento;
			tbIdadePai.Text = _registroNascimento.IdadePai.ToString();
			tbNomeDeclarante.Text = _registroNascimento.NomeDeclarante;
			tbNomeLivro.Text = _registroNascimento.NomeLivro;
			tbNomeMae.Text = _registroNascimento.NomeMae;
			tbNomePai.Text = _registroNascimento.NomePai;
			tbNomeRegistrado.Text = _registroNascimento.NomeRegistrado;
			tbNumeroFolha.Text = _registroNascimento.NumeroFolha.ToString();
			tbNumeroLivro.Text = _registroNascimento.NumeroLivro.ToString();
			tbNumeroRegistro.Text = _registroNascimento.NumeroRegistro.ToString();
			tbPosicaoFolha.Text = _registroNascimento.PosicaoFolha.ToString();
			tbUF.Text = _registroNascimento.UF;
		}

		private RegistroNascimento ConveterParaObjeto()
		{
			return new RegistroNascimento
			{
				Id = _registroNascimento?.Id ?? 0,
				Cidade = tbCidade.Text,
				CodigoDeclarante = char.Parse(tbCodigoDeclarante.Text),
				DataNascimento = tbDataNascimento.Value.Date,
				IdadePai = int.Parse(tbIdadePai.Text),
				NomeDeclarante = tbNomeDeclarante.Text,
				NomeLivro = tbNomeLivro.Text,
				NomeMae = tbNomeMae.Text,
				NomePai = tbNomePai.Text,
				NomeRegistrado = tbNomeRegistrado.Text,
				NumeroFolha = int.Parse(tbNumeroFolha.Text),
				NumeroLivro = int.Parse(tbNumeroLivro.Text),
				NumeroRegistro = int.Parse(tbNumeroRegistro.Text),
				PosicaoFolha = char.Parse(tbPosicaoFolha.Text),
				UF = tbUF.Text
			};
		}

		private void MantemDados()
		{
			var entidade = ConveterParaObjeto();
			var repositorio = new RepositorioRegistroNascimento();
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
