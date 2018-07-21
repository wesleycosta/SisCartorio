using Npgsql;
using System.Collections.Generic;
using System.Data;

namespace Repositorio.Implementacoes.BaseDeDados
{
	public class Conexao
	{
		#region PROPRIEDADES E CONSTRUTORES

		private readonly NpgsqlConnection _conexao;
		public NpgsqlCommand _cmd;
		public NpgsqlDataReader _leitor;

		public Conexao()
		{
			var config = ConfiguracaoDb.LerConfiguracao();
			_conexao = new NpgsqlConnection(config.StringDeConexao);
		}

		#endregion

		#region ABRIR E FECHAR CONEXÃO

		private void AbrirConexao()
		{
			if (_conexao.State != ConnectionState.Closed)
			{
				_conexao.Close();
			}

			_conexao.Open();
		}

		private void FecharConexao()
		{
			_cmd = null;
			_leitor = null;

			_conexao.Close();
		}

		#endregion

		#region EXECUTAR E LER DADOS

		public void Executar(string query, Dictionary<string, object> parametrosDicionario = null)
		{
			var parametros = new List<NpgsqlParameter>();

			if (parametrosDicionario != null)
			{
				parametros = GetParametros(parametrosDicionario);
			}

			AbrirConexao();
			_cmd = new NpgsqlCommand(query, _conexao);
			parametros.ForEach(p => _cmd.Parameters.Add(p));
			_cmd.ExecuteNonQuery();
			FecharConexao();
		}

		public int ExecutarScalar(string query, Dictionary<string, object> parametrosDicionario = null)
		{
			var parametros = new List<NpgsqlParameter>();

			if (parametrosDicionario != null)
			{
				parametros = GetParametros(parametrosDicionario);
			}

			AbrirConexao();
			_cmd = new NpgsqlCommand(query, _conexao);
			parametros.ForEach(p => _cmd.Parameters.Add(p));
			var id = (int) _cmd.ExecuteScalar();
			FecharConexao();

			return id;
		}

		public List<Dictionary<string, object>> Ler(string query, 
				Dictionary<string, object> parametrosDicionario = null)
		{
			var dados = new List<Dictionary<string, object>>();
			var parametros = new List<NpgsqlParameter>();

			if (parametrosDicionario != null)
			{
				parametros = GetParametros(parametrosDicionario);
			}

			AbrirConexao();
			_cmd = new NpgsqlCommand(query, _conexao);
			parametros.ForEach(x => _cmd.Parameters.Add(x));
			_leitor = _cmd.ExecuteReader();

			while (_leitor.Read())
			{
				var item = new Dictionary<string, object>();

				for (int i = 0; i < _leitor.FieldCount; i++)
				{
					item.Add(_leitor.GetName(i), _leitor[i]);
				}

				dados.Add(item);
			}

			FecharConexao();

			return dados;
		}

		private List<NpgsqlParameter> GetParametros(Dictionary<string, object> parametros = null)
		{
			var lista = new List<NpgsqlParameter>();

			if (parametros == null) return lista;

			foreach (var item in parametros)
			{
				lista.Add(new NpgsqlParameter(item.Key, item.Value));
			}

			return lista;
		}

		#endregion
	}
}
