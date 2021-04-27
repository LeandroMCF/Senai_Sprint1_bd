using Hroads.Contexts;
using Hroads.Domains;
using Hroads.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hroads.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Cadastrar(Habilidade novaHabilidade)
        {
            ctx.Habilidades.Add(novaHabilidade);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Habilidade habilidade = ctx.Habilidades.Find(id);

            ctx.Habilidades.Remove(habilidade);

            ctx.SaveChanges();
        }

        public List<Habilidade> Listar()
        {
            return ctx.Habilidades.Include(h => h.IdTipoHabilidadesNavigation).Include(h => h.Classes).ToList();
        }
    }
}
