using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongManGym.Models
{
    public class Clanovi : Person
    {
        public int SifraClana { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodenja { get; set; }
        public string Kontakt { get; set; }
        public string StatusClanarine { get; set; }
    }
}
