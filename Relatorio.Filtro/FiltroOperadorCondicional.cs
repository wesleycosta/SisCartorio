using Entidades;

namespace Relatorio.Filtro
{
	public class FiltroOperadorCondicional
	{
		public string Campo { get; set; }
		public string ValorFiltro01 { get; set; }
		public string ValorFiltro02 { get; set; }
		public OperadorCondicional OperadorCondicional { get; set; }
		public bool CampoData { get; set; }
	}
}