using Hroads.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hroads.Interfaces
{
    interface ITipoHabilidadeRepository
    {
        List<TipoHabilidade> Listar();
        void Cadastrar(TipoHabilidade novoTipo);
        void Deletar(int id);
        void Atualizar(int id, TipoHabilidade novoTipo);
    }
}
