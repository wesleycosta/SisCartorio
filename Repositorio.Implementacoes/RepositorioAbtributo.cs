using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using Repositorio.Contratos;
using Repositorio.Implementacoes.BaseDeDados;

namespace Repositorio.Implementacoes
{
	public class RepositorioAbtributo : IRepositorioAtributo
	{
		#region MANTEM REGISTRO

		public void Salvar(Atributo entidade)
		{
			if (entidade.Id > 0)
			{
				Atualizar(entidade);
			}
			else
			{
				Inserir(entidade);
			}
		}

		public void Inserir(Atributo entidade)
		{
			#region QUERY

			var query = @"INSERT INTO atributo_relatorio
							(id_modelo_relatorio, titulo, campo_chave, tamanho_coluna, alinhamento)
						  VALUES
							(@id_modelo_relatorio, @titulo, @campo_chave, @tamanho_coluna, @alinhamento)";

			#endregion

			var parametros = GetParametros(entidade);
			var conexao = new Conexao();
			conexao.Executar(query, parametros);
		}

		public void Atualizar(Atributo entidade)
		{
			#region QUERY

			var query = @"UPDATE atributo_relatorio SET
							id_modelo_relatorio 	= @id_modelo_relatorio,
							titulo					= @titulo,
							campo_chave				= @campo_chave,
							tamanho_coluna			= @tamanho_coluna,
							alinhamento				= @alinhamento
						  WHERE
							id_atributo_relatorio 	= @id";

			#endregion

			var parametros = GetParametros(entidade);
			parametros.Add("id", entidade.Id);

			var conexao = new Conexao();
			conexao.Executar(query, parametros);
		}

		public void Remover(Atributo entidade)
		{
			#region QUERY

			var query = @"DELETE FROM
							atributo_relatorio
						  WHERE
							id_atributo_relatorio = @id";

			#endregion

			var parametros = GetIdParametro(entidade);
			var conexao = new Conexao();
			conexao.Executar(query, parametros);
		}

		#endregion

		#region CARREGAR 

		public Atributo CarregarPorId(int id)
		{
			#region QUERY

			var query = @"SELECT
							id_modelo_relatorio,
							titulo,
							campo_chave,
							tamanho_coluna,
							alinhamento
						 FROM
							atributo_relatorio
						 WHERE
							id_atributo_relatorio = @id";
			#endregion

			var parametros = GetIdParametro(id);
			var conexao = new Conexao();
			var dados = conexao.Ler(query, parametros);

			return dados.Select(r =>
				new Atributo
				{
					Id = id,
					IdRelatorioModelo = int.Parse(r["id_modelo_relatorio"].ToString()),
					Titulo = r["titulo"].ToString(),
					CampoChave = r["campo_chave"].ToString(),
					TamanhoColuna = int.Parse(r["tamanho_coluna"].ToString()),
					Alinhamento = (AlinhamentoColuna)Enum.Parse(typeof(AlinhamentoColuna), r[""].ToString())
				}).FirstOrDefault();
		}

		public List<Atributo> CarregarPorIdModeloRelatorio(int id)
		{
			#region QUERY

			var query = @"SELECT
							id_atributo_relatorio,
							titulo,
							campo_chave,
							tamanho_coluna,
							alinhamento
						 FROM
							atributo_relatorio
						 WHERE
							id_modelo_relatorio = @id";
			#endregion

			var parametros = GetIdParametro(id);
			var conexao = new Conexao();
			var dados = conexao.Ler(query, parametros);

			return dados.Select(r =>
				new Atributo
				{
					IdRelatorioModelo = id,
					Id = int.Parse(r["id_atributo_relatorio"].ToString()),
					Titulo = r["titulo"].ToString(),
					CampoChave = r["campo_chave"].ToString(),
					TamanhoColuna = int.Parse(r["tamanho_coluna"].ToString()),
					Alinhamento = (AlinhamentoColuna)Enum.Parse(typeof(AlinhamentoColuna), r["alinhamento"].ToString())
				}).ToList();
		}

		public List<Atributo> CarregarTodos()
		{
			#region QUERY

			var query = @"SELECT
							id_atributo_relatorio,
							id_modelo_relatorio,
							titulo,
							campo_chave,
							tamanho_coluna,
							alinhamento
						 FROM
							atributo_relatorio
						 ORDER BY
							id_atributo_relatorio";

			#endregion

			var conexao = new Conexao();
			var dados = conexao.Ler(query);

			return dados.Select(r => new Atributo
			{
				Id = int.Parse(r["id_atributo_relatorio"].ToString()),
				IdRelatorioModelo = int.Parse(r["id_modelo_relatorio"].ToString()),
				Titulo = r["titulo"].ToString(),
				CampoChave = r["campo_chave"].ToString(),
				TamanhoColuna = int.Parse(r["tamanho_coluna"].ToString()),
				Alinhamento = (AlinhamentoColuna)Enum.Parse(typeof(AlinhamentoColuna), r[""].ToString())
			}).ToList();
		}

		#endregion

		#region PARAMETROS

		private Dictionary<string, object> GetIdParametro(Atributo entidade) =>
			GetIdParametro(entidade.Id);

		private Dictionary<string, object> GetIdParametro(int id)
		{
			var parametros = new Dictionary<string, object>
			{
				{ "id", id }
			};

			return parametros;
		}

		private Dictionary<string, object> GetParametros(Atributo entidade)
		{
			var parametros = new Dictionary<string, object>
			{
				{ "id_modelo_relatorio", entidade.IdRelatorioModelo },
				{ "titulo", entidade.Titulo },
				{ "campo_chave", entidade.CampoChave },
				{ "tamanho_coluna", entidade.TamanhoColuna },
				{ "alinhamento", (int)entidade.Alinhamento }
			};

			return parametros;
		}

		#endregion
	}
}
