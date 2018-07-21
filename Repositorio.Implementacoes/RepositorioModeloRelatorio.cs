using System.Linq;
using System.Collections.Generic;

using Entidades;
using Repositorio.Contratos;
using Repositorio.Implementacoes.BaseDeDados;
using System;

namespace Repositorio.Implementacoes
{
	public class RepositorioModeloRelatorio : IRepositorioModeloRelatorio
	{

		#region MANTEM REGISTRO

		public void Salvar(ModeloRelatorio entidade)
		{
			if (entidade.Id > 0)
				Atualizar(entidade);
			else
				Inserir(entidade);
		}

		public void Inserir(ModeloRelatorio entidade)
		{
			#region QUERY

			var query = @"INSERT INTO modelo_relatorio (
							   titulo,
							   tipo_de_registro,
							   campo_data,
							   aplicar_condicao,
							   campo_condicao_01,
							   operador_condicional_01,
							   valor_campo_01,
							   operador_logico,
							   campo_condicao_02,
							   operador_condicional_02,
							   valor_campo_02,
							   imprimir_cabecalho,
							   imprimir_rodape,
							   imprimir_sumario )
						  VALUES (
							  @titulo,
							  @tipo_de_registro,
							  @campo_data,
							  @aplicar_condicao,
							  @campo_condicao_01,
							  @operador_condicional_01,
							  @valor_campo_01,
							  @operador_logico,
							  @campo_condicao_02,
							  @operador_condicional_02,
							  @valor_campo_02,
							  @imprimir_cabecalho,
							  @imprimir_rodape,
							  @imprimir_sumario ) RETURNING id_modelo_relatorio";

			#endregion

			var parametros = GetParametros(entidade);
			var conexao = new Conexao();
			entidade.Id = conexao.ExecutarScalar(query, parametros);
		}

		public void Atualizar(ModeloRelatorio entidade)
		{
			#region QUERY

			var query = @"UPDATE modelo_relatorio 		SET
							titulo						= @titulo,
							tipo_de_registro			= @tipo_de_registro,
							campo_data					= @campo_data,
							aplicar_condicao			= @aplicar_condicao, 
							campo_condicao_01			= @campo_condicao_01,
							operador_condicional_01		= @operador_condicional_01,
							valor_campo_01				= @valor_campo_01,
							operador_logico				= @operador_logico,
							campo_condicao_02			= @campo_condicao_02,
							operador_condicional_02		= @operador_condicional_02,
							valor_campo_02				= @valor_campo_02,
							imprimir_cabecalho			= @imprimir_cabecalho,
							imprimir_rodape				= @imprimir_rodape,
							imprimir_sumario			= @imprimir_sumario
						  WHERE
							id_modelo_relatorio			= @id";

			#endregion

			var parametros = GetParametros(entidade);
			parametros.Add("id", entidade.Id);

			var conexao = new Conexao();
			conexao.Executar(query, parametros);
		}

		public void Salvar(ModeloRelatorio modelo, List<Atributo> atributoSet)
		{
			var repositorioAtributo = new RepositorioAbtributo();

			Salvar(modelo);
			atributoSet.ForEach(a => a.IdRelatorioModelo = modelo.Id);
			atributoSet.ForEach(a => repositorioAtributo.Salvar(a));
		}

		public void Remover(ModeloRelatorio entidade)
		{
			RemoverAtributo(entidade.AtributoSet);

			#region QUERY

			var query = @"DELETE FROM 
							 modelo_relatorio
						  WHERE
							 id_modelo_relatorio = @id";

			#endregion

			var parametros = GetIdParametro(entidade);
			var conexao = new Conexao();
			conexao.Executar(query, parametros);
		}

		private void RemoverAtributo(List<Atributo> atributoSet)
		{
			var repositorio = new RepositorioAbtributo();
			atributoSet.ForEach(x => repositorio.Remover(x));
		}

		#endregion

		#region CARREGAR

		public ModeloRelatorio CarregarPorId(int id)
		{
			#region QUERY

			var query = @"SELECT
							titulo,
							tipo_de_registro,
							campo_data,
						    aplicar_condicao,
							campo_condicao_01,
							operador_condicional_01,
							valor_campo_01,
							operador_logico,
							campo_condicao_02,
							operador_condicional_02,
							valor_campo_02,
							imprimir_cabecalho,
							imprimir_rodape,
							imprimir_sumario 
						  FROM
							modelo_relatorio
						  WHERE
							id_modelo_relatorio = @id";
			#endregion

			var parametros = GetIdParametro(id);
			var conexao = new Conexao();
			var dados = conexao.Ler(query, parametros);

			var modelo = dados.Select(r =>
			   new ModeloRelatorio
			   {
				   Id = id,
				   Titulo = r["titulo"].ToString(),
				   TipoDeRegistro = (TipoDeRegistro)Enum.Parse(typeof(TipoDeRegistro), r["tipo_de_registro"].ToString()),
				   CampoData = r["campo_data"].ToString(),
				   AplicarCondicao = bool.Parse(r["aplicar_condicao"].ToString()),
				   CampoCodicao01 = r["campo_condicao_01"].ToString(),
				   OperadorCondicional01 = (OperadorCondicional)Enum.Parse(typeof(OperadorCondicional), r["operador_condicional_01"].ToString()),
				   ValorCampo01 = r["valor_campo_01"].ToString(),
				   OperadorLogico = (OperadorLogico)Enum.Parse(typeof(OperadorLogico), r["operador_logico"].ToString()),
				   CampoCodicao02 = r["campo_condicao_02"].ToString(),
				   OperadorCondicional02 = (OperadorCondicional)Enum.Parse(typeof(OperadorCondicional), r["operador_condicional_02"].ToString()),
				   ValorCampo02 = r["valor_campo_02"].ToString(),
				   ImprimirCabecalho = (TipoDeImpressao)Enum.Parse(typeof(TipoDeImpressao), r["imprimir_cabecalho"].ToString()),
				   ImprimirRodape = (TipoDeImpressao)Enum.Parse(typeof(TipoDeImpressao), r["imprimir_rodape"].ToString()),
				   ImprimirSumario = bool.Parse(r["imprimir_sumario"].ToString())
			   }).First();

			var repositorioAtributo = new RepositorioAbtributo();
			modelo.AtributoSet = repositorioAtributo.CarregarPorIdModeloRelatorio(modelo.Id);

			return modelo;
		}

		public List<ModeloRelatorio> CarregarTodos()
		{
			#region QUERY

			var query = @"SELECT
							id_modelo_relatorio,
							titulo,
							tipo_de_registro,
							campo_data,
							aplicar_condicao,
							campo_condicao_01,
							operador_condicional_01,
							valor_campo_01,
							operador_logico,
							campo_condicao_02,
							operador_condicional_02,
							valor_campo_02,
							imprimir_cabecalho,
							imprimir_rodape,
							imprimir_sumario 
						  FROM
							modelo_relatorio
						  ORDER BY
							id_modelo_relatorio";
			#endregion

			var conexao = new Conexao();
			var dados = conexao.Ler(query);

			var modeloSet = dados.Select(r =>
			   new ModeloRelatorio
			   {
				   Id = int.Parse(r["id_modelo_relatorio"].ToString()),
				   Titulo = r["titulo"].ToString(),
				   TipoDeRegistro = (TipoDeRegistro)Enum.Parse(typeof(TipoDeRegistro), r["tipo_de_registro"].ToString()),
				   CampoData = r["campo_data"].ToString(),
				   AplicarCondicao = bool.Parse(r["aplicar_condicao"].ToString()),
				   CampoCodicao01 = r["campo_condicao_01"].ToString(),
				   OperadorCondicional01 = (OperadorCondicional)Enum.Parse(typeof(OperadorCondicional), r["operador_condicional_01"].ToString()),
				   ValorCampo01 = r["valor_campo_01"].ToString(),
				   OperadorLogico = (OperadorLogico)Enum.Parse(typeof(OperadorLogico), r["operador_logico"].ToString()),
				   CampoCodicao02 = r["campo_condicao_02"].ToString(),
				   OperadorCondicional02 = (OperadorCondicional)Enum.Parse(typeof(OperadorCondicional), r["operador_condicional_02"].ToString()),
				   ValorCampo02 = r["valor_campo_02"].ToString(),
				   ImprimirCabecalho = (TipoDeImpressao)Enum.Parse(typeof(TipoDeImpressao), r["imprimir_cabecalho"].ToString()),
				   ImprimirRodape = (TipoDeImpressao)Enum.Parse(typeof(TipoDeImpressao), r["imprimir_rodape"].ToString()),
				   ImprimirSumario = bool.Parse(r["imprimir_sumario"].ToString())
			   }).ToList();

			var repositorioAtributo = new RepositorioAbtributo();
			modeloSet.ForEach(x => x.AtributoSet = repositorioAtributo.CarregarPorIdModeloRelatorio(x.Id));

			return modeloSet;
		}

		#endregion

		#region PARAMETROS

		private Dictionary<string, object> GetIdParametro(ModeloRelatorio entidade) =>
			GetIdParametro(entidade.Id);

		private Dictionary<string, object> GetIdParametro(int id)
		{
			var parametros = new Dictionary<string, object>
			{
				{ "id", id }
			};

			return parametros;
		}

		private Dictionary<string, object> GetParametros(ModeloRelatorio entidade)
		{
			var parametros = new Dictionary<string, object>
			{
				{"titulo", entidade.Titulo},
				{"tipo_de_registro", (int) entidade.TipoDeRegistro},
				{"campo_data", entidade.CampoData},
				{"aplicar_condicao", entidade.AplicarCondicao},
				{"campo_condicao_01", entidade.CampoCodicao01},
				{"operador_condicional_01", (int) entidade.OperadorCondicional01},
				{"valor_campo_01", entidade.ValorCampo01},
				{"operador_logico", (int) entidade.OperadorLogico},
				{"campo_condicao_02", entidade.CampoCodicao02},
				{"operador_condicional_02", (int) entidade.OperadorCondicional02},
				{"valor_campo_02", entidade.ValorCampo02},
				{"imprimir_cabecalho", (int) entidade.ImprimirCabecalho},
				{"imprimir_rodape", (int) entidade.ImprimirRodape},
				{"imprimir_sumario", entidade.ImprimirSumario}
			};


			return parametros;
		}

		#endregion
	}
}