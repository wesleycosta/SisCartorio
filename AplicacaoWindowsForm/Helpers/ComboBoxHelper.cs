using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Entidades;
using Relatorio.Filtro;

namespace AplicacaoWindowsForm.Helpers
{
	public class ComboBoxHelper
	{
		#region CARREGAR COMBO BOX

		public void CarregarCampos(ref ComboBox cbCampoData, ref ComboBox cbCamposEntidade01, ref ComboBox cbCamposEntidade02, TipoDeRegistro tipoDeRegistro)
		{
			cbCampoData.Items.Clear();
			cbCamposEntidade01.Items.Clear();
			cbCamposEntidade02.Items.Clear();

			CarregarCombo(ref cbCampoData, GetPropriedadesEntidade(tipoDeRegistro, true));
			CarregarCombo(ref cbCamposEntidade01, GetPropriedadesEntidade(tipoDeRegistro));
			CarregarCombo(ref cbCamposEntidade02, GetPropriedadesEntidade(tipoDeRegistro));
		}

		public void CarregarCampos(ref ComboBox cbComboCamposEntidade, TipoDeRegistro tipoDeRegistro)
		{
			cbComboCamposEntidade.Items.Clear();
			CarregarCombo(ref cbComboCamposEntidade, GetPropriedadesEntidade(tipoDeRegistro, false, true));
			SelecionePrimeiroItem(ref cbComboCamposEntidade);
		}

		private void CarregarCombo(ref ComboBox comboBox, List<FiltroDescricao> filtroDescricaoSet)
		{
			foreach (var item in filtroDescricaoSet)
			{
				comboBox.Items.Add(item.Descricao);
			}

			SelecionePrimeiroItem(ref comboBox);
		}

		#endregion

		#region MANIPUÇÃO DE PROPRIEDADES DAS ENTIDADES

		public string GetNomeCampo(TipoDeRegistro tipoDeRegistro, string descricao, bool campoData = false)
		{
			var lista = GetPropriedadesEntidade(tipoDeRegistro, campoData);

			return lista.FirstOrDefault(x => x.Descricao == descricao)?.NomeDoCampo ?? "";
		}

		public string GetDescricaoDoCampo(TipoDeRegistro tipoDeRegistro, string nomeCampo, bool campoData = false)
		{
			var lista = GetPropriedadesEntidade(tipoDeRegistro, campoData);

			return lista.FirstOrDefault(x => x.NomeDoCampo == nomeCampo)?.Descricao ?? "";
		}

		private List<FiltroDescricao> GetPropriedadesEntidade(TipoDeRegistro tipoDeRegistro, bool apenasTipoData = false, bool trazerTipoData = false)
		{
			switch (tipoDeRegistro)
			{
				case TipoDeRegistro.Nascimento:
					{
						var filtro = new Filtro();
						return filtro.GetPropriedadesTipoData<RegistroNascimento>(apenasTipoData, trazerTipoData);
					}
				case TipoDeRegistro.Casamento:
					{
						var filtro = new Filtro();
						return filtro.GetPropriedadesTipoData<RegistroCasamento>(apenasTipoData, trazerTipoData);
					}
				default:
					{
						var filtro = new Filtro();
						return filtro.GetPropriedadesTipoData<RegistroObito>(apenasTipoData, trazerTipoData);
					}
			}
		}

		#endregion

		#region SELECIONAR ITEM

		public void SelecionarItem(ref ComboBox comboBox, string nomeDoCampo, TipoDeRegistro tipoDeRegistro, bool campoData = false)
		{
			var descricaoCampo = GetDescricaoDoCampo(tipoDeRegistro, nomeDoCampo, campoData);
			comboBox.SelectedItem = descricaoCampo;
		}

		private void SelecionePrimeiroItem(ref ComboBox cb)
		{
			if (cb.Items.Count > 0)
				cb.SelectedIndex = 0;
		}

		#endregion
	}
}
