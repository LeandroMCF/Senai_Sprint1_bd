using System;
using System.Collections.Generic;

#nullable disable

namespace Hroads.Domains
{
    public partial class Class
    {
        public Class()
        {
            Personagens = new HashSet<Personagen>();
        }

        public int IdClasses { get; set; }
        public int? IdHabilidades { get; set; }
        public string Classes { get; set; }

        public virtual Habilidade IdHabilidadesNavigation { get; set; }
        public virtual ICollection<Personagen> Personagens { get; set; }
    }
}
