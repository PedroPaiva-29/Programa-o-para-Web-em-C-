using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Repository.Interfaces
{
    public interface ICoordenadorRepository
    {
        Task<IEnumerable<Coordenador>> ListarTodosASync();
        Task<Coordenador> ListarPorIdASync(int id);
        Task AdicionarAsync(Coordenador coordenador);
        Task AlterarAsync(Coordenador coordenador);
        Task ExcluirAsync(int id);
    }
}
