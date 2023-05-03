using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongManGym.Models
{
    public class Clanovi : Person
    {
        public int IdClana { get; set; }
        public string E_mail { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Kontakt { get; set; }
        public string StatusClanarine { get; set; }
    }
}
