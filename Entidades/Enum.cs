namespace Entidades
{
	public enum TipoDeRegistro
	{
		Nascimento = 0,
		Casamento = 1,
		Obito = 2
	}

	public enum OperadorCondicional
	{
		IgualA = 0,
		DiferenteDe = 1,
		MaiorQue = 2,
		MaiorOuIgualA = 3,
		MenorQue = 4,
		MenorOuIgualA = 5
	}

	public enum OperadorLogico
	{
		Nenhum = 0,
		E = 1,
		Ou = 2
	}

	public enum TipoDeImpressao
	{
		ApenasPrimeiraPagina = 1
	}

	public enum AlinhamentoColuna
	{
		Centralizado,
		Esquerda
	}
}