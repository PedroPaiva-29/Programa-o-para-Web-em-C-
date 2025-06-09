using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface ICursoService
    {
        Task<IEnumerable<Curso>> ListarTodosASync();
        Task<Curso?> ListarPorIdASync(int id);
        Task<int> AdicionarAsync(Curso curso);
        Task<bool> AlterarAsync(Curso curso);
        Task<bool> ExcluirAsync(int id);
    }
}
