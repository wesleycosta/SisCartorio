using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AplicacaoWindowsForm.Telas.Casamento
{
	using Helpers;
	using Entidades;
	using Repositorio.Implementacoes;

	public partial class FrmCadCasamento : Form
	{
		#region PROPRIEDADES

		public bool Salvou { get; set; }

		private readonly RegistroCasamento _registroCasamento;

		#endregion

		#region CONSTRUTORES 

		public FrmCadCasamento()
		{
			InitializeComponent();
			AdicionarValidacoes();
		}

		public FrmCadCasamento(RegistroCasamento registroCasamento)
		{
			_registroCasamento = registroCasamento;
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
			tbNomeLivro.Text = _registroCasamento.NomeLivro;
			tbNumeroFolha.Text = _registroCasamento.NumeroFolha.ToString();
			tbNumeroLivro.Text = _registroCasamento.NumeroLivro.ToString();
			tbNumeroRegistro.Text = _registroCasamento.NumeroRegistro.ToString();
			tbPosicaoFolha.Text = _registroCasamento.PosicaoFolha.ToString();

			tbNomeContraente1.Text = _registroCasamento.NomeContraente1;
			tbDataNascimentoContraente1.Value = _registroCasamento.DataNascimentoContraente1;
			tbCidadeContraente1.Text = _registroCasamento.CidadeContraente1;
			tbUFContraente1.Text = _registroCasamento.UFContraente1;

			tbNomeContraente2.Text = _registroCasamento.NomeContraente2;
			tbDataNascimentoContraente2.Value = _registroCasamento.DataNascimentoContraente2;
			tbCidadeContraente2.Text = _registroCasamento.CidadeContraente2;
			tbUFContraente2.Text = _registroCasamento.UFContraente2;
		}

		private RegistroCasamento ConveterParaObjeto()
		{
			return new RegistroCasamento
			{
				Id = _registroCasamento?.Id ?? 0,
				NomeContraente1 = tbNomeContraente1.Text,
				DataNascimentoContraente1 = tbDataNascimentoContraente1.Value,
				CidadeContraente1 = tbCidadeContraente1.Text,
				UFContraente1 = tbUFContraente1.Text,

				NomeContraente2 = tbNomeContraente2.Text,
				DataNascimentoContraente2 = tbDataNascimentoContraente2.Value,
				CidadeContraente2 = tbCidadeContraente2.Text,
				UFContraente2 = tbUFContraente2.Text,

				NomeLivro = tbNomeLivro.Text,
				NumeroFolha = int.Parse(tbNumeroFolha.Text),
				NumeroLivro = int.Parse(tbNumeroLivro.Text),
				NumeroRegistro = int.Parse(tbNumeroRegistro.Text),
				PosicaoFolha = char.Parse(tbPosicaoFolha.Text),
			};
		}

		private void MantemDados()
		{
			var entidade = ConveterParaObjeto();
			var repositorio = new RepositorioRegistroCasamento();
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
				Mensagens.MensagemCampoInvalido(erroSet);
		}

		#endregion

		#region EVENTOS

		private void btnSalvar_Click(object sender, EventArgs e) => Salvar();

		private void btnCancelar_Click(object sender, EventArgs e) => Close();

		#endregion
	}
}
