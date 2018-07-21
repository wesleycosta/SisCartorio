using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Relatorios.Modelos;
using System;
using System.Diagnostics;

using Entidades;
using System.Linq;

namespace Relatorios.Helpers
{
	public class ImpressaoDePdf
	{
		#region CONSTANTES

		private const int NUMERO_DE_REGISTROS_POR_PAGINA = 45;

		private const int INICIO_AREA_Y = 80;

		private const string FONTE_PADRAO = "Courier";

		#endregion

		#region GERAÇÃO DO RELATÓRIO

		public void GerarRelatorio(RelatorioLayout modelo)
		{
			PdfDocument document = new PdfDocument();


			var totalLinhas = modelo.ColunasSet[0].LinhasSet.Count;
			var numeroDePaginasComTabela = Math.Ceiling((decimal)totalLinhas / NUMERO_DE_REGISTROS_POR_PAGINA);
			var limite = 0;

			for (int i = 0; i < numeroDePaginasComTabela; i++)
			{
				document.AddPage();
				limite += NUMERO_DE_REGISTROS_POR_PAGINA;
				limite = limite > totalLinhas ? totalLinhas : limite;

				CriarTabela(ref document, modelo, i, NUMERO_DE_REGISTROS_POR_PAGINA * i, limite);
			}

			if (modelo.ImpimirSumario)
				CriarSumario(ref document, modelo);

			CriarCabecalho(ref document, modelo);
			CriarRodape(ref document, modelo);

			Abrir(ref document);
		}

		private void Abrir(ref PdfDocument document)
		{
			var nomeArquivo = $"relatorio_{Guid.NewGuid()}.pdf";
			document.Save(nomeArquivo);
			Process.Start(nomeArquivo);
		}

		#endregion

		#region CRIAÇÃO DO CORPO DO RELATÓRIO

		private void CriarCabecalho(ref PdfDocument document, RelatorioLayout modelo)
		{
			for (int i = 0; i < document.Pages.Count; ++i)
				if (modelo.ImprimirRodape != TipoDeImpressao.ApenasPrimeiraPagina || i == 0)
				{
					var periodo = $"Período: {modelo.DataInicial.ToShortDateString()} até {modelo.DataFinal.ToShortDateString()}";

					Imprimir(ref document, i, modelo.Titulo, 16, true, 0, 30, AlinhamentoColuna.Centralizado);
					Imprimir(ref document, i, periodo, 7, false, 0, 60, AlinhamentoColuna.Centralizado);
				}
		}

		private void CriarRodape(ref PdfDocument document, RelatorioLayout modelo)
		{
			var totalPagina = document.Pages.Count;
			for (int i = 0; i < document.Pages.Count; ++i)
				if (modelo.ImprimirRodape != TipoDeImpressao.ApenasPrimeiraPagina || i == 0)
				{
					var pagina = document.Pages[i];
					var rodape = $"Relatório emitido em: {DateTime.Now.ToShortDateString()} às {DateTime.Now.ToShortTimeString()}{new string(' ', 150)}";
					rodape += $"Página {(i + 1):D3} de {(totalPagina):D3}.";

					Imprimir(ref document, i, rodape, 7, false, 0, (int)pagina.Height - 40, AlinhamentoColuna.Centralizado);
				}
		}

		private void CriarSumario(ref PdfDocument document, RelatorioLayout modelo)
		{
			document.AddPage();

			var totalRegistros = modelo.ColunasSet.Sum(x => x.LinhasSet.Count) / modelo.ColunasSet.Count;
			var index = document.Pages.Count - 1;
			var pagina = document.Pages[index];

			Imprimir(ref document, index, "SUMÁRIO", 10, true, 0, INICIO_AREA_Y + 3, AlinhamentoColuna.Centralizado);
			Imprimir(ref document, index, $"TOTAL DE REGISTROS: {(totalRegistros):D5}", 7, false, 0, INICIO_AREA_Y + 25, AlinhamentoColuna.Centralizado);
			Imprimir(ref document, index, $"DATA: {DateTime.Now.ToShortDateString()}", 7, false, 0, INICIO_AREA_Y + 40, AlinhamentoColuna.Centralizado);
		}

		private void CriarTabela(ref PdfDocument document, RelatorioLayout modelo, int pagina = 0, int inicio = 0, int limite = 0)
		{
			var alturaColuna = 15;
			var colunaPosicaoX = 30;
			var colunaPosicaoY = INICIO_AREA_Y;
			var linhaY = colunaPosicaoY + alturaColuna;

			foreach (var m in modelo.ColunasSet)
			{
				ImprimirRetangulo(ref document, pagina, colunaPosicaoX, colunaPosicaoY, m,
					m.Titulo, m.Alinhamento, true, alturaColuna);

				for (var j = inicio; j < limite; j++)
				{
					ImprimirRetangulo(ref document, pagina, colunaPosicaoX, linhaY, m,
						m.LinhasSet[j], m.Alinhamento, false, alturaColuna);

					linhaY += alturaColuna;
				}

				linhaY = colunaPosicaoY + alturaColuna;
				colunaPosicaoX += m.TamanhoColuna;
			}
		}

		#endregion

		#region IMPRIMIR

		private void ImprimirRetangulo(ref PdfDocument document, int indexPagina, int x, int y, Coluna coluna, string texto,
									   AlinhamentoColuna alinhamento, bool destaque = false, int altura = 15)
		{
			texto = texto.ToUpper();
			var font = new XFont(FONTE_PADRAO, 7, destaque ? XFontStyle.Bold : XFontStyle.Regular);
			var brush = XBrushes.Black;
			var pagina = document.Pages[indexPagina];

			using (XGraphics gfx = XGraphics.FromPdfPage(pagina))
			{
				var largura = coluna.TamanhoColuna;

				var retangulo = new XRect(x, y, largura, altura);

				if (alinhamento != AlinhamentoColuna.Centralizado)
				{
					retangulo.X += 3;
					retangulo.Y += 3;
				}

				var pen = new XPen(XColors.Black, 0.5);

				gfx.DrawRectangle(pen, destaque ? XBrushes.LightSteelBlue : XBrushes.White, x, y, largura, altura);

				switch (alinhamento)
				{
					case AlinhamentoColuna.Centralizado:
						gfx.DrawString(texto, font, brush, retangulo, XStringFormats.Center);
						break;
					case AlinhamentoColuna.Esquerda:
						gfx.DrawString(texto, font, brush, retangulo, XStringFormats.TopLeft);
						break;
					default:
						gfx.DrawString(texto, font, brush, x + largura - texto.Length * 5, y + (altura / 2) + 2);
						break;
				}
			}
		}

		private void Imprimir(ref PdfDocument document, int indexPagina, string texto, int TamanhoFonte, bool negrito,
							  int x, int y, AlinhamentoColuna alinhamento)
		{
			var font = new XFont(FONTE_PADRAO, TamanhoFonte, negrito ? XFontStyle.Bold : XFontStyle.Regular);
			var brush = XBrushes.Black;
			var pagina = document.Pages[indexPagina];
			var retangulo = new XRect(x, y, pagina.Width, font.Height);

			using (var gfx = XGraphics.FromPdfPage(pagina))
			{
				var cabecalho = texto;
				gfx.DrawString(cabecalho, font, brush, retangulo, alinhamento == AlinhamentoColuna.Centralizado
																  ? XStringFormats.TopCenter
																  : alinhamento == AlinhamentoColuna.Esquerda
																  ? XStringFormats.TopLeft :
																	XStringFormats.Default);
			}
		}

		#endregion
	}
}
