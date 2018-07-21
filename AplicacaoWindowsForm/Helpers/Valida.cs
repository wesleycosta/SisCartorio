using System.Windows.Forms;
using System.Collections.Generic;

namespace AplicacaoWindowsForm.Helpers
{
	public class Valida
	{
		#region EVENTOS DE VALIDAÇÕES

		// EVENTO KEY PRESS PARA VALIDAR NUMEROS NATURAIS
		public static void Naturais_KeyPress(object sender, KeyPressEventArgs e)
		{
			int ascii = e.KeyChar;

			if ((ascii < 48 || ascii > 57) && ascii != 8)
				e.Handled = true;
		}


		#endregion

		#region VALIDA CAMPOS OBRIGATÓRIOS

		public static void ValidaCamposObrigatorios(Control.ControlCollection controls, ref List<CampoInvalido> camposInvalidosSet)
		{
			foreach (var c in controls)
			{
				switch (c)
				{
					case TextBox tb:
						if (tb.Text == string.Empty && tb.Tag != null)
						{
							camposInvalidosSet.Add(new CampoInvalido
							{
								Index = tb.TabIndex,
								Campo = tb,
								Descricao = tb.Tag.ToString()
							});
						}

						break;
					case GroupBox gb:
						ValidaCamposObrigatorios(gb.Controls, ref camposInvalidosSet);
						break;
				}
			}
		}

		#endregion
	}
}
