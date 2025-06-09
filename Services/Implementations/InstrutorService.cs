using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class InstrutorService : IInstrutorService
    {
        private readonly SQLServerDbContext _contexto;

        public InstrutorService(SQLServerDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<int> AdicionarAsync(Instrutor instrutor)
        {
            _contexto.Instrutores.Add(instrutor);
            await _contexto.SaveChangesAsync();
            return instrutor.InstrutorId;
        }

        public async Task<bool> AlterarAsync(Instrutor instrutor)
        {
            var instrutorExiste = await _contexto.Instrutores.FindAsync(instrutor.InstrutorId);
            if (instrutorExiste == null)
            {
                return false;
            }
            _contexto.Entry(instrutorExiste).CurrentValues.SetValues(instrutor);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExcluirAsync(int id)
        {
            var instrutor = await _contexto.Instrutores.FindAsync(id);
            if (instrutor == null)
            {
                return false;
            }
            _contexto.Instrutores.Remove(instrutor);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<Instrutor?> ListarPorIdASync(int id)
        {
            return await _contexto.Instrutores.AsNoTracking().FirstOrDefaultAsync(x => x.InstrutorId == id);
        }

        public async Task<IEnumerable<Instrutor>> ListarTodosASync()
        {
            return await _contexto.Instrutores.AsNoTracking().OrderBy(x => x.InstrutorId).ToListAsync();
        }
    }
}
