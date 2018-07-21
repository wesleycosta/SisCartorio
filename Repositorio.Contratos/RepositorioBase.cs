using System.Collections.Generic;

using Entidades;

namespace Repositorio.Contratos
{
	public abstract class RepositorioBase<TEntidade> where TEntidade : RegistroBase
	{
		protected Dictionary<string, object> GetIdParametro(TEntidade entidade)
		{
			return GetIdParametro(entidade.Id);
		}

		protected Dictionary<string, object> GetIdParametro(int id)
		{
			return new Dictionary<string, object> { { "id", id } };
		}
	}
}
