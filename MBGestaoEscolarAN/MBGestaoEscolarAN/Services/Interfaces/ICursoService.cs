using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface ICursoService
    {
        Task<IEnumerable<Curso>> ListarTodosASync();
        Task<Curso> ListarPorIdASync(int id);
        Task AdicionarAsync(Curso curso);
        Task AlterarAsync(Curso curso);
        Task ExcluirAsync(int id);
    }
}
