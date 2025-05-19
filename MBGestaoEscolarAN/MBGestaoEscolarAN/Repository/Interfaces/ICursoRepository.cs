using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Repository.Interfaces
{
    public interface ICursoRepository
    {
        Task<IEnumerable<Curso>> ListarTodosASync();
        Task<Curso> ListarPorIdASync(int id);
        Task AdicionarAsync(Curso curso);
        Task AlterarAsync(Curso curso);
        Task ExcluirAsync(int id);
    }
}
