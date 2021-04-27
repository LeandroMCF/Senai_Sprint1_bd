using Hroads.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hroads.Interfaces
{
    interface IHabilidadeRepository
    {
        List<Habilidade> Listar();
        void Cadastrar(Habilidade novaHabilidade);
        void Deletar(int id);
    }
}
