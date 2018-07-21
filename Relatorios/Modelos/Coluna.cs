using Entidades;
using System.Collections.Generic;

namespace Relatorios.Modelos
{
	public class Coluna
	{
		public string Titulo { get; set; }
		public int TamanhoColuna { get; set; }
		public AlinhamentoColuna Alinhamento { get; set; }
		public List<string> LinhasSet { get; set; }
	}
}
