using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;

using Repositorio.Contratos;
using Repositorio.Implementacoes.BaseDeDados;

namespace Repositorio.Implementacoes
{
	public class RepositorioRegistroObito :
		RepositorioBase<RegistroObito>, IRepositorioRegistroObito
	{
		#region MANTEM REGISTRO

		public void Salvar(RegistroObito entidade)
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

		public void Inserir(RegistroObito entidade)
		{
			#region QUERY

			var query = @"INSERT INTO registro_obito (
							 nome_livro,
							 numero_livro,
							 numero_folha,
							 posicao_folha,
							 numero_registro,
							 data_registro,
							 nome_falecido,
							 data_falecimento,
							 eleitor,
							 reservista,
							 nome_declarante,
							 nome_pai,
							 nome_mae,
							 cidade,
							 uf )
						 VALUES (
							@nome_livro,
							@numero_livro,
							@numero_folha,
							@posicao_folha,
							@numero_registro,
							@data_registro,
							@nome_falecido,
							@data_falecimento,
							@eleitor,
							@reservista,
							@nome_declarante,
							@nome_pai,
							@nome_mae,
							@cidade,
							@uf)";

			#endregion

			var parametros = GetParametros(entidade);
			var conexao = new Conexao();
			conexao.Executar(query, parametros);
		}

		public void Atualizar(RegistroObito entidade)
		{
			#region QUERY

			var query = @"UPDATE registro_obito SET
							 nome_livro				= @nome_livro,
							 numero_livro			= @numero_livro,
							 numero_folha			= @numero_folha,
							 posicao_folha			= @posicao_folha,
							 numero_registro		= @numero_registro,
							 data_registro			= @data_registro,
							 nome_falecido			= @nome_falecido,
							 data_falecimento		= @data_falecimento,
							 eleitor				= @eleitor,
							 reservista				= @reservista,
							 nome_declarante		= @nome_declarante,
							 nome_pai				= @nome_pai,
							 nome_mae				= @nome_mae,
							 cidade					= @cidade,
							 uf						= @uf
						 WHERE
							id_registro_obito	= @id";

			#endregion

			var parametros = GetParametros(entidade);
			parametros.Add("id", entidade.Id);

			var conexao = new Conexao();
			conexao.Executar(query, parametros);
		}

		public void Remover(RegistroObito entidade)
		{
			#region QUERY

			var query = @"DELETE FROM 
							registro_obito 
						 WHERE
							id_registro_obito = @id";

			#endregion

			var parametros = GetIdParametro(entidade);
			var conexao = new Conexao();
			conexao.Executar(query, parametros);
		}

		#endregion

		#region CARREGAR

		public RegistroObito CarregarPorId(int id)
		{
			#region QUERY

			var query = @"SELECT 
							 nome_livro,
							 numero_livro,
							 numero_folha,
							 posicao_folha,
							 numero_registro,
							 data_registro,
							 nome_falecido,
							 data_falecimento,
							 eleitor,
							 reservista,
							 nome_declarante,
							 nome_pai,
							 nome_mae,
							 cidade,
							 uf 
						FROM
							registro_obito
						WHERE
							id_registro_obito = @id";
			#endregion

			var parametros = GetIdParametro(id);
			var conexao = new Conexao();
			var dados = conexao.Ler(query, parametros);

			return dados.Select(r =>
				new RegistroObito
				{
					Id = id,
					NomeLivro = r["nome_livro"].ToString(),
					NumeroLivro = int.Parse(r["numero_livro"].ToString()),
					NumeroFolha = int.Parse(r["numero_folha"].ToString()),
					PosicaoFolha = char.Parse(r["posicao_folha"].ToString()),
					NumeroRegistro = int.Parse(r["numero_registro"].ToString()),
					DataRegistro = DateTime.Parse(r["data_registro"].ToString()),

					DataFalecimento = DateTime.Parse(r["data_falecimento"].ToString()),
					Eleitor = bool.Parse(r["eleitor"].ToString()),
					NomeFalecido = r["nome_falecido"].ToString(),
					Reservista = bool.Parse(r["reservista"].ToString()),
					NomeDeclarante = r["nome_declarante"].ToString(),
					NomePai = r["nome_pai"].ToString(),
					NomeMae = r["nome_mae"].ToString(),
					Cidade = r["cidade"].ToString(),
					UF = r["uf"].ToString()
				}).FirstOrDefault();
		}

		public List<RegistroObito> CarregarTodos()
		{
			#region QUERY

			var query = @"SELECT 
							 id_registro_obito,
							 nome_livro,
							 numero_livro,
							 numero_folha,
							 posicao_folha,
							 numero_registro,
							 data_registro,
							 nome_falecido,
							 data_falecimento,
							 eleitor,
							 reservista,
							 nome_declarante,
							 nome_pai,
							 nome_mae,
							 cidade,
							 uf 
						FROM
							registro_obito
						ORDER BY
							id_registro_obito";

			#endregion

			var conexao = new Conexao();
			var dados = conexao.Ler(query);

			return dados.Select(r => new RegistroObito
			{
				Id = int.Parse(r["id_registro_obito"].ToString()),
				NomeLivro = r["nome_livro"].ToString(),
				NumeroLivro = int.Parse(r["numero_livro"].ToString()),
				NumeroFolha = int.Parse(r["numero_folha"].ToString()),
				PosicaoFolha = char.Parse(r["posicao_folha"].ToString()),
				NumeroRegistro = int.Parse(r["numero_registro"].ToString()),
				DataRegistro = DateTime.Parse(r["data_registro"].ToString()),

				DataFalecimento = DateTime.Parse(r["data_falecimento"].ToString()),
				Eleitor = bool.Parse(r["eleitor"].ToString()),
				NomeFalecido = r["nome_falecido"].ToString(),
				Reservista = bool.Parse(r["reservista"].ToString()),
				NomeDeclarante = r["nome_declarante"].ToString(),
				NomePai = r["nome_pai"].ToString(),
				NomeMae = r["nome_mae"].ToString(),
				Cidade = r["cidade"].ToString(),
				UF = r["uf"].ToString()
			}).ToList();
		}

		#endregion

		#region PARAMETROS

		private Dictionary<string, object> GetParametros(RegistroObito entidade)
		{
			var parametros = new Dictionary<string, object>
			{
				{ "nome_livro", entidade.NomeLivro },
				{ "numero_livro", entidade.NumeroLivro },
				{ "numero_folha", entidade.NumeroFolha },
				{ "posicao_folha", entidade.PosicaoFolha },
				{ "numero_registro", entidade.NumeroRegistro },
				{ "data_registro", entidade.DataRegistro },

				{ "nome_falecido", entidade.NomeFalecido },
				{ "data_falecimento", entidade.DataFalecimento },
				{ "eleitor", entidade.Eleitor },
				{ "reservista", entidade.Reservista },
				{ "nome_declarante", entidade.NomeDeclarante },
				{ "nome_pai", entidade.NomePai },
				{ "nome_mae", entidade.NomeMae },
				{ "cidade", entidade.Cidade },
				{ "uf", entidade.UF }
			};

			return parametros;
		}

		#endregion
	}
}
