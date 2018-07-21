using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;

using Repositorio.Contratos;
using Repositorio.Implementacoes.BaseDeDados;

namespace Repositorio.Implementacoes
{
	public class RepositorioRegistroNascimento :
		RepositorioBase<RegistroNascimento>, IRepositorioRegistroNascimento
	{
		#region MANTEM REGISTRO

		public void Salvar(RegistroNascimento entidade)
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

		public void Inserir(RegistroNascimento entidade)
		{
			#region QUERY

			var query = @"INSERT INTO registro_nascimento (
							 nome_livro,
							 numero_livro,
							 numero_folha,
							 posicao_folha,
							 numero_registro,
							 data_registro,
							 nome_registrado,
							 data_nascimento,
							 codigo_declarante,
							 nome_declarante,
							 nome_pai,
							 idade_pai,
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
							@nome_registrado,
							@data_nascimento,
							@codigo_declarante,
							@nome_declarante,
							@nome_pai,
							@idade_pai,
							@nome_mae,
							@cidade,
							@uf)";

			#endregion

			var parametros = GetParametros(entidade);
			var conexao = new Conexao();
			conexao.Executar(query, parametros);
		}

		public void Atualizar(RegistroNascimento entidade)
		{
			#region QUERY

			var query = @"UPDATE registro_nascimento SET
							 nome_livro				= @nome_livro,
							 numero_livro			= @numero_livro,
							 numero_folha			= @numero_folha,
							 posicao_folha			= @posicao_folha,
							 numero_registro		= @numero_registro,
							 data_registro			= @data_registro,
							 nome_registrado		= @nome_registrado,
							 data_nascimento		= @data_nascimento,
							 codigo_declarante		= @codigo_declarante,
							 nome_declarante		= @nome_declarante,
							 nome_pai				= @nome_pai,
							 idade_pai				= @idade_pai,
							 nome_mae				= @nome_mae,
							 cidade					= @cidade,
							 uf						= @uf
						 WHERE
							id_registro_nascimento	= @id";

			#endregion

			var parametros = GetParametros(entidade);
			parametros.Add("id", entidade.Id);

			var conexao = new Conexao();
			conexao.Executar(query, parametros);
		}

		public void Remover(RegistroNascimento entidade)
		{
			#region QUERY

			var query = @"DELETE FROM 
							registro_nascimento 
						 WHERE
							id_registro_nascimento	= @id";

			#endregion

			var parametros = GetIdParametro(entidade);
			var conexao = new Conexao();
			conexao.Executar(query, parametros);
		}

		#endregion

		#region CARREGAR

		public RegistroNascimento CarregarPorId(int id)
		{
			#region QUERY

			var query = @"SELECT 
							 nome_livro,
							 numero_livro,
							 numero_folha,
							 posicao_folha,
							 numero_registro,
							 data_registro,
							 nome_registrado,
							 data_nascimento,
							 codigo_declarante,
							 nome_declarante,
							 nome_pai,
							 idade_pai,
							 nome_mae,
							 cidade,
							 uf 
						FROM
							registro_nascimento
						WHERE
							id_registro_nascimento = @id";
			#endregion

			var parametros = GetIdParametro(id);
			var conexao = new Conexao();
			var dados = conexao.Ler(query, parametros);

			return dados.Select(r =>
				new RegistroNascimento
				{
					Id = id,
					NomeLivro = r["nome_livro"].ToString(),
					NumeroLivro = int.Parse(r["numero_livro"].ToString()),
					NumeroFolha = int.Parse(r["numero_folha"].ToString()),
					PosicaoFolha = char.Parse(r["posicao_folha"].ToString()),
					NumeroRegistro = int.Parse(r["numero_registro"].ToString()),
					DataRegistro = DateTime.Parse(r["data_registro"].ToString()),

					NomeRegistrado = r["nome_registrado"].ToString(),
					DataNascimento = DateTime.Parse(r["data_nascimento"].ToString()),
					CodigoDeclarante = char.Parse(r["codigo_declarante"].ToString()),
					NomeDeclarante = r["nome_declarante"].ToString(),
					NomePai = r["nome_pai"].ToString(),
					IdadePai = int.Parse(r["idade_pai"].ToString()),
					NomeMae = r["nome_mae"].ToString(),
					Cidade = r["cidade"].ToString(),
					UF = r["uf"].ToString()
				}).FirstOrDefault();
		}

		public List<RegistroNascimento> CarregarTodos()
		{
			#region QUERY

			var query = @"SELECT 
							 id_registro_nascimento,
							 nome_livro,
							 numero_livro,
							 numero_folha,
							 posicao_folha,
							 numero_registro,
							 data_registro,
							 nome_registrado,
							 data_nascimento,
							 codigo_declarante,
							 nome_declarante,
							 nome_pai,
							 idade_pai,
							 nome_mae,
							 cidade,
							 uf 
						FROM
							registro_nascimento
						ORDER BY
							id_registro_nascimento";

			#endregion

			var conexao = new Conexao();
			var dados = conexao.Ler(query);

			return dados.Select(r => new RegistroNascimento
			{
				Id = int.Parse(r["id_registro_nascimento"].ToString()),
				NomeLivro = r["nome_livro"].ToString(),
				NumeroLivro = int.Parse(r["numero_livro"].ToString()),
				NumeroFolha = int.Parse(r["numero_folha"].ToString()),
				PosicaoFolha = char.Parse(r["posicao_folha"].ToString()),
				NumeroRegistro = int.Parse(r["numero_registro"].ToString()),
				DataRegistro = DateTime.Parse(r["data_registro"].ToString()),

				NomeRegistrado = r["nome_registrado"].ToString(),
				DataNascimento = DateTime.Parse(r["data_nascimento"].ToString()),
				CodigoDeclarante = char.Parse(r["codigo_declarante"].ToString()),
				NomeDeclarante = r["nome_declarante"].ToString(),
				NomePai = r["nome_pai"].ToString(),
				IdadePai = int.Parse(r["idade_pai"].ToString()),
				NomeMae = r["nome_mae"].ToString(),
				Cidade = r["cidade"].ToString(),
				UF = r["uf"].ToString()
			}).ToList();
		}

		#endregion

		#region PARAMETROS

		private Dictionary<string, object> GetParametros(RegistroNascimento entidade)
		{
			var parametros = new Dictionary<string, object>
			{
				{ "nome_livro", entidade.NomeLivro },
				{ "numero_livro", entidade.NumeroLivro },
				{ "numero_folha", entidade.NumeroFolha },
				{ "posicao_folha", entidade.PosicaoFolha },
				{ "numero_registro", entidade.NumeroRegistro },
				{ "data_registro", entidade.DataRegistro },

				{ "nome_registrado", entidade.NomeRegistrado },
				{ "data_nascimento", entidade.DataNascimento },
				{ "codigo_declarante", entidade.CodigoDeclarante },
				{ "nome_declarante", entidade.NomeDeclarante },
				{ "nome_pai", entidade.NomePai },
				{ "idade_pai", entidade.IdadePai },
				{ "nome_mae", entidade.NomeMae },
				{ "cidade", entidade.Cidade },
				{ "uf", entidade.UF }
			};

			return parametros;
		}

		#endregion
	}
}
