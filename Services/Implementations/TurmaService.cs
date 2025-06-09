using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Entities;
using MBGestaoEscolarAN.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolarAN.Services.Implementations
{
    public class TurmaService:ITurmaService
    {
        private readonly SQLServerDbContext _contexto;

        public TurmaService(SQLServerDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<int> AdicionarAsync(Turma turma)
        {
            _contexto.Turmas.Add(turma);
            await _contexto.SaveChangesAsync();
            return turma.turmaId;
        }

        public async Task<bool> AlterarAsync(Turma turma)
        {
            var turmaExiste = await _contexto.Turmas.FindAsync(turma.turmaId);
            if (turmaExiste == null)
            {
                return false;
            }
            _contexto.Entry(turmaExiste).CurrentValues.SetValues(turma);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExcluirAsync(int id)
        {
            var turma = await _contexto.Turmas.FindAsync(id);
            if (turma == null)
            {
                return false;
            }
            _contexto.Turmas.Remove(turma);
            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<Turma?> ListarPorIdASync(int id)
        {
            return await _contexto.Turmas.AsNoTracking().FirstOrDefaultAsync(x => x.turmaId == id);
        }

        public async Task<IEnumerable<Turma>> ListarTodosASync()
        {
            return await _contexto.Turmas.AsNoTracking().OrderBy(x => x.turmaId).ToListAsync();
        }
    }
}
