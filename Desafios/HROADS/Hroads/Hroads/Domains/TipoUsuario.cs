using System;
using System.Collections.Generic;

#nullable disable

namespace Hroads.Domains
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdTipoUsuarios { get; set; }
        public string TipoUsuarios { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
