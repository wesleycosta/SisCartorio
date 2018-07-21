using System;
using System.Collections.Generic;
using Entidades;
using Relatorios.Helpers;
using Repositorio.Implementacoes;


namespace Relatorios
{
	public class ServicoRelatorio
	{
		public void GerarRelatorio(ModeloRelatorio modelo, DateTime dtInicial, DateTime dtFinal)
		{
			switch (modelo.TipoDeRegistro)
			{
				case TipoDeRegistro.Nascimento:
					GerarRelatorioRegistroNascimento(modelo, dtInicial, dtFinal);
					break;
				case TipoDeRegistro.Casamento:
					GerarRelatorioRegistroCasamento(modelo, dtInicial, dtFinal);
					break;
				case TipoDeRegistro.Obito:
					GerarRelatorioRegistroObito(modelo, dtInicial, dtFinal);
					break;
			}
		}

		private void GerarRelatorioRegistroNascimento(ModeloRelatorio modelo, DateTime dtInicial, DateTime dtFinal)
		{
			var repositorioNascimento = new RepositorioRegistroNascimento();
			var nascimentoSet = repositorioNascimento.CarregarTodos();
			var filtroDados = new FiltroDados<RegistroNascimento>();

			nascimentoSet = filtroDados.FiltrarRegistros(modelo, nascimentoSet, dtInicial, dtFinal);

			if (nascimentoSet.Count == 0)
			{
				throw new Exception("Não há dados a serem impressos.");
			}

			GerarRelatorio(modelo, dtInicial, dtFinal, nascimentoSet);
		}

		private void GerarRelatorioRegistroCasamento(ModeloRelatorio modelo, DateTime dtInicial, DateTime dtFinal)
		{
			var repositorioCasamento = new RepositorioRegistroCasamento();
			var casamentoSet = repositorioCasamento.CarregarTodos();

			var filtroDados = new FiltroDados<RegistroCasamento>();
			casamentoSet = filtroDados.FiltrarRegistros(modelo, casamentoSet, dtInicial, dtFinal);

			if (casamentoSet.Count == 0)
			{
				throw new Exception("Não há dados a serem impressos.");
			}

			GerarRelatorio(modelo, dtInicial, dtFinal, casamentoSet);
		}

		private void GerarRelatorioRegistroObito(ModeloRelatorio modelo, DateTime dtInicial, DateTime dtFinal)
		{
			var repositorioObito = new RepositorioRegistroObito();
			var obitoSet = repositorioObito.CarregarTodos();
			var filtroDados = new FiltroDados<RegistroObito>();

			obitoSet = filtroDados.FiltrarRegistros(modelo, obitoSet, dtInicial, dtFinal);

			if (obitoSet.Count == 0)
			{
				throw new Exception("Não há dados a serem impressos.");
			}

			GerarRelatorio(modelo, dtInicial, dtFinal, obitoSet);
		}

		private void GerarRelatorio<T>(ModeloRelatorio modelo, DateTime dtInicial, DateTime dtFinal, List<T> entidadeSet)
		{
			var relatorioLayout = new Maperadores.RelatorioMapeador().Mapear(modelo, entidadeSet, dtInicial, dtFinal);
			var impressaoEmpdf = new ImpressaoDePdf();
			impressaoEmpdf.GerarRelatorio(relatorioLayout);
		}
	}
}