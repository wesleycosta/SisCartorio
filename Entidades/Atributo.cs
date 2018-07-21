namespace Entidades
{
	public class Atributo
	{
		public int Id { get; set; }
		public int IdRelatorioModelo { get; set; }
		public string Titulo { get; set; }
		public string CampoChave { get; set; }
		public int TamanhoColuna { get; set; }
		public AlinhamentoColuna Alinhamento { get; set; }
	}
}
