using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Repository.Interfaces
{
    public interface IInstrutorRepository
    {
        Task<IEnumerable<Instrutor>> ListarTodosASync();
        Task<Instrutor> ListarPorIdASync(int id);
        Task AdicionarAsync(Instrutor instrutor);
        Task AlterarAsync(Instrutor instrutor);
        Task ExcluirAsync(int id);
    }
}
