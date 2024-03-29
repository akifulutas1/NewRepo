using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek
{
    public class Buch
    {
        public string Titel { get; set; }
        public string ISBN { get; set; }
        public int Seitenzahl { get; set; }
        public int Erscheinungsjahr { get; set; }
        public string Preiskategorie { get; set; }
    }
}
