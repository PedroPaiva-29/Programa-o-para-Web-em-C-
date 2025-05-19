using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface IAlunoService
    {
        Task<IEnumerable<Aluno>> ListarTodosASync();
        Task<Aluno> ListarPorIdASync(int id);
        Task AdicionarAsync(Aluno aluno);
        Task AlterarAsync(Aluno aluno);
        Task ExcluirAsync(int id);
    }
}
