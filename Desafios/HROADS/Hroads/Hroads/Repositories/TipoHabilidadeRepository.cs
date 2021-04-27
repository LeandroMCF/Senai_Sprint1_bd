using Hroads.Contexts;
using Hroads.Domains;
using Hroads.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hroads.Repositories
{
    public class TipoHabilidadeRepository : ITipoHabilidadeRepository
    {
        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int id, TipoHabilidade novoTipo)
        {
            TipoHabilidade tipo = new TipoHabilidade();

            if (tipo.TipoHabilidades == novoTipo.TipoHabilidades)
            {
                tipo.TipoHabilidades = novoTipo.TipoHabilidades;
            }

            ctx.TipoHabilidades.Update(tipo);

            ctx.SaveChanges();
        }

        public void Cadastrar(TipoHabilidade novoTipo)
        {
            ctx.TipoHabilidades.Add(novoTipo);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            TipoHabilidade tipo = ctx.TipoHabilidades.Find(id);

            ctx.TipoHabilidades.Remove(tipo);

            ctx.SaveChanges();
        }

        public List<TipoHabilidade> Listar()
        {
            return ctx.TipoHabilidades.ToList();
        }
    }
}
