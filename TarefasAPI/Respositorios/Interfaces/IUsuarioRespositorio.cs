using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Respositorios.Interfaces
{
    public interface IUsuarioRespositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();

        Task<UsuarioModel> BuscarPorId(int Id);

        Task<UsuarioModel> Adicionar(UsuarioModel usuario);

        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int Id);

        Task<bool> Apagar(int Id);
    }
}
