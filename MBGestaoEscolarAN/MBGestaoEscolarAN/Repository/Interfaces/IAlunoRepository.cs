using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Repository.Interfaces
{
    public interface IAlunoRepository
    {
        Task<IEnumerable<Aluno>> ListarTodosASync();
        Task<Aluno> ListarPorIdASync(int id);
        Task AdicionarAsync(Aluno aluno);
        Task AlterarAsync(Aluno aluno);
        Task ExcluirAsync(int id);
    }
}
