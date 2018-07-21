using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;

using Repositorio.Contratos;
using Repositorio.Implementacoes.BaseDeDados;

namespace Repositorio.Implementacoes
{
	public class RepositorioRegistroCasamento :
		RepositorioBase<RegistroCasamento>, IRepositorioRegistroCasamento
	{
		#region MANTEM REGISTRO

		public void Salvar(RegistroCasamento entidade)
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

		public void Inserir(RegistroCasamento entidade)
		{
			#region QUERY

			var query = @"INSERT INTO registro_casamento (
							nome_livro,
							numero_livro,
							numero_folha,
							posicao_folha,
							numero_registro,
							data_registro,
							nome_contraente1,
							data_nascimento_contraente1,
							cidade_contraente1,
							uf_contraente1,
							nome_contraente2,
							data_nascimento_contraente2, 
							cidade_contraente2,
							uf_contraente2)
						VALUES (
							@nome_livro,
							@numero_livro,
							@numero_folha,
							@posicao_folha,
							@numero_registro,
							@data_registro,
							@nome_contraente1,
							@data_nascimento_contraente1,
							@cidade_contraente1,
							@uf_contraente1,
							@nome_contraente2,
							@data_nascimento_contraente2, 
							@cidade_contraente2,
							@uf_contraente2)";

			#endregion

			var parametros = GetParametros(entidade);
			var conexao = new Conexao();
			conexao.Executar(query, parametros);
		}

		public void Atualizar(RegistroCasamento entidade)
		{
			#region QUERY

			var query = @"UPDATE registro_casamento SET
							nome_livro						= @nome_livro,
							numero_livro					= @numero_livro,
							numero_folha					= @numero_folha,
							posicao_folha					= @posicao_folha,
							numero_registro					= @numero_registro,
							data_registro					= @data_registro,
							nome_contraente1				= @nome_contraente1,
							data_nascimento_contraente1		= @data_nascimento_contraente1,
							cidade_contraente1				= @cidade_contraente1,
							uf_contraente1					= @uf_contraente1,
							nome_contraente2				= @nome_contraente2,
							data_nascimento_contraente2		= @data_nascimento_contraente2, 
							cidade_contraente2				= @cidade_contraente2,
							uf_contraente2					= @uf_contraente2
						 WHERE
							id_registro_casamento	= @id";

			#endregion

			var parametros = GetParametros(entidade);
			parametros.Add("id", entidade.Id);

			var conexao = new Conexao();
			conexao.Executar(query, parametros);
		}

		public void Remover(RegistroCasamento entidade)
		{
			#region QUERY

			var query = @"DELETE FROM 
							registro_casamento 
						 WHERE
							id_registro_casamento = @id";

			#endregion

			var parametros = GetIdParametro(entidade);
			var conexao = new Conexao();
			conexao.Executar(query, parametros);
		}

		#endregion

		#region CARREGAR

		public RegistroCasamento CarregarPorId(int id)
		{
			#region QUERY

			var query = @"SELECT
							id_registro_casamento,
							nome_livro,
							numero_livro,
							numero_folha,
							posicao_folha,
							numero_registro,
							data_registro,
							nome_contraente1,
							data_nascimento_contraente1,
							cidade_contraente1,
							uf_contraente1,
							nome_contraente2,
							data_nascimento_contraente2,
							cidade_contraente2,
							uf_contraente2
						FROM 
							registro_casamento
						WHERE
							id_registro_casamento = @id";
			#endregion

			var parametros = GetIdParametro(id);
			var conexao = new Conexao();
			var dados = conexao.Ler(query, parametros);

			return dados.Select(r =>
				new RegistroCasamento
				{
					Id = id,
					NomeLivro = r["nome_livro"].ToString(),
					NumeroLivro = int.Parse(r["numero_livro"].ToString()),
					NumeroFolha = int.Parse(r["numero_folha"].ToString()),
					PosicaoFolha = char.Parse(r["posicao_folha"].ToString()),
					NumeroRegistro = int.Parse(r["numero_registro"].ToString()),
					DataRegistro = DateTime.Parse(r["data_registro"].ToString()),

					CidadeContraente1 = r["cidade_contraente1"].ToString(),
					CidadeContraente2 = r["cidade_contraente2"].ToString(),
					DataNascimentoContraente1 = DateTime.Parse(r["data_nascimento_contraente1"].ToString()),
					DataNascimentoContraente2 = DateTime.Parse(r["data_nascimento_contraente2"].ToString()),
					NomeContraente1 = r["nome_contraente1"].ToString(),
					NomeContraente2 = r["nome_contraente2"].ToString(),
					UFContraente1 = r["uf_contraente1"].ToString(),
					UFContraente2 = r["uf_contraente2"].ToString()
				}).FirstOrDefault();
		}

		public List<RegistroCasamento> CarregarTodos()
		{
			#region QUERY

			var query = @"SELECT
							id_registro_casamento,
							nome_livro,
							numero_livro,
							numero_folha,
							posicao_folha,
							numero_registro,
							data_registro,
							nome_contraente1,
							data_nascimento_contraente1,
							cidade_contraente1,
							uf_contraente1,
							nome_contraente2,
							data_nascimento_contraente2,
							cidade_contraente2,
							uf_contraente2
						FROM 
							registro_casamento
						ORDER BY
							id_registro_casamento";

			#endregion

			var conexao = new Conexao();
			var dados = conexao.Ler(query);

			return dados.Select(r => new RegistroCasamento
			{
				Id = int.Parse(r["id_registro_casamento"].ToString()),
				NomeLivro = r["nome_livro"].ToString(),
				NumeroLivro = int.Parse(r["numero_livro"].ToString()),
				NumeroFolha = int.Parse(r["numero_folha"].ToString()),
				PosicaoFolha = char.Parse(r["posicao_folha"].ToString()),
				NumeroRegistro = int.Parse(r["numero_registro"].ToString()),
				DataRegistro = DateTime.Parse(r["data_registro"].ToString()),

				CidadeContraente1 = r["cidade_contraente1"].ToString(),
				CidadeContraente2 = r["cidade_contraente2"].ToString(),
				DataNascimentoContraente1 = DateTime.Parse(r["data_nascimento_contraente1"].ToString()),
				DataNascimentoContraente2 = DateTime.Parse(r["data_nascimento_contraente2"].ToString()),
				NomeContraente1 = r["nome_contraente1"].ToString(),
				NomeContraente2 = r["nome_contraente2"].ToString(),
				UFContraente1 = r["uf_contraente1"].ToString(),
				UFContraente2 = r["uf_contraente2"].ToString()
			}).ToList();
		}

		#endregion

		#region PARAMETROS

		private Dictionary<string, object> GetParametros(RegistroCasamento entidade)
		{
			var parametros = new Dictionary<string, object>
			{
				{ "nome_livro", entidade.NomeLivro },
				{ "numero_livro", entidade.NumeroLivro },
				{ "numero_folha", entidade.NumeroFolha },
				{ "posicao_folha", entidade.PosicaoFolha },
				{ "numero_registro", entidade.NumeroRegistro },
				{ "data_registro", entidade.DataRegistro },

				{ "cidade_contraente1", entidade.CidadeContraente1 },
				{ "cidade_contraente2", entidade.CidadeContraente2 },
				{ "data_nascimento_contraente1", entidade.DataNascimentoContraente1 },
				{ "data_nascimento_contraente2", entidade.DataNascimentoContraente2 },
				{ "nome_contraente1", entidade.NomeContraente1 },
				{ "nome_contraente2", entidade.NomeContraente2 },
				{ "uf_contraente1", entidade.UFContraente1 },
				{ "uf_contraente2", entidade.UFContraente2 }
			};

			return parametros;
		}

		#endregion
	}
}
