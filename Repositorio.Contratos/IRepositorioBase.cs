using System.Collections.Generic;

namespace Repositorio.Contratos
{
	public interface IRepositorioBase<TEntidade>
	{
		void Inserir(TEntidade entidade);
		void Remover(TEntidade entidade);
		void Atualizar(TEntidade entidade);
		TEntidade CarregarPorId(int id);
		List<TEntidade> CarregarTodos();
	}
}
