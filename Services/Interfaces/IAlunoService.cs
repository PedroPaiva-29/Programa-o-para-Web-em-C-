using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface IAlunoService
    {
        Task<IEnumerable<Aluno>> ListarTodosASync();
        Task<Aluno?> ListarPorIdASync(int id);
        Task<int> AdicionarAsync(Aluno aluno);
        Task<bool> AlterarAsync(Aluno aluno);
        Task<bool> ExcluirAsync(int id);
    }
}
