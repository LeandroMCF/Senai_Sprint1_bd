using System;
using System.Collections.Generic;

#nullable disable

namespace Hroads.Domains
{
    public partial class Personagen
    {
        public int IdPersonagens { get; set; }
        public int? IdClasses { get; set; }
        public string Nome { get; set; }
        public string CapacidadeMaxVida { get; set; }
        public string CapacidadeMaxMana { get; set; }
        public string DataDeAtt { get; set; }
        public string DataDeCriacao { get; set; }

        public virtual Class IdClassesNavigation { get; set; }
    }
}
