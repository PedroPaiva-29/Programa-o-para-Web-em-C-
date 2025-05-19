using MBGestaoEscolarAN.Entities;

namespace MBGestaoEscolarAN.Services.Interfaces
{
    public interface ICoordenadorService
    {
        Task<IEnumerable<Coordenador>> ListarTodosASync();
        Task<Coordenador> ListarPorIdASync(int id);
        Task AdicionarAsync(Coordenador coordenador);
        Task AlterarAsync(Coordenador coordenador);
        Task ExcluirAsync(int id);
    }
}
