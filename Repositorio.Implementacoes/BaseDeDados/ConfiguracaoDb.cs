using System;
using System.IO;
using System.Xml.Serialization;

namespace Repositorio.Implementacoes.BaseDeDados
{
	[XmlRoot("configuration")]
	public class ConfiguracaoDb
	{
		#region PROPRIEDADES

		[XmlElement("servidor")]
		public string Servidor { get; set; }

		[XmlElement("usuario")]
		public string Usuario { get; set; }

		[XmlElement("senha")]
		public string Senha { get; set; }

		[XmlElement("banco")]
		public string NomeBaseDeDados { get; set; }

		public string StringDeConexao =>
			$"Server={Servidor}; Port=5432; User Id={Usuario};Password={Senha};Database={NomeBaseDeDados};";

		#endregion

		#region LER CONFIGURAÇÃO

		public static ConfiguracaoDb LerConfiguracao()
		{
			ConfiguracaoDb config = null;

			try
			{
				if (File.Exists("App.Config"))
				{
					var serializer = new XmlSerializer(typeof(ConfiguracaoDb));
					using (TextReader reader = new StringReader(File.ReadAllText("App.config")))
					{
						config = (ConfiguracaoDb)serializer.Deserialize(reader);
					}
				}

			}
			catch (Exception)
			{
				// ignored
			}

			return config;
		}

		#endregion
	}
}
