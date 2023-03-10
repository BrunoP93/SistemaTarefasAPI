using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Respositorios.Interfaces
{
    public interface ITarefaRepositorio
    {
        Task<List<TarefaModel>> BuscarTodasTarefas();

        Task<TarefaModel> BuscarPorId(int Id);

        Task<TarefaModel> Adicionar(TarefaModel tarefa);

        Task<TarefaModel> Atualizar(TarefaModel tarefa, int Id);

        Task<bool> Apagar(int Id);
    }
}
