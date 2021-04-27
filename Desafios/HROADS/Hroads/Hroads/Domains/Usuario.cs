using System;
using System.Collections.Generic;

#nullable disable

namespace Hroads.Domains
{
    public partial class Usuario
    {
        public int IdUsuarios { get; set; }
        public int? IdTipoUsuarios { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TipoUsuario IdTipoUsuariosNavigation { get; set; }
        public virtual ICollection<TipoUsuario> TipoUsuarios { get; set; }
    }
}
