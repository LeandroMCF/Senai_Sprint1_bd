using System;
using System.Collections.Generic;

#nullable disable

namespace Hroads.Domains
{
    public partial class Habilidade
    {
        public Habilidade()
        {
            Classes = new HashSet<Class>();
        }

        public int IdHabilidades { get; set; }
        public int? IdTipoHabilidades { get; set; }
        public string Habilidades { get; set; }
        public virtual TipoHabilidade IdTipoHabilidadesNavigation { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }
}
