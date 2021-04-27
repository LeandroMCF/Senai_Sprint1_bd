using System;
using System.Collections.Generic;

#nullable disable

namespace Hroads.Domains
{
    public partial class TipoHabilidade
    {
        public TipoHabilidade()
        {
            Habilidades = new HashSet<Habilidade>();
        }

        public int IdTipoHabilidades { get; set; }
        public string TipoHabilidades { get; set; }

        public virtual ICollection<Habilidade> Habilidades { get; set; }
    }
}
