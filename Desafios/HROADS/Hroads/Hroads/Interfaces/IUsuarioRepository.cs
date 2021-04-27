using Hroads.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hroads.Interfaces
{
    interface IUsuarioRepository
    {
        Usuario Login(string email, string senha);
        void cadastrar(Usuario novoUsuario);
        List<Usuario> Listar();
        void Deletar(int id);
        Usuario BuscarPorId(int id);
    }
}
