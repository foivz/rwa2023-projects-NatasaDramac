using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongManGym.Models
{
    public class Clan : Person
    {
        [DisplayName("Id")]
        public int IdClana { get; set; }

        [DisplayName("E-mail")]
        public string E_mail { get; set; }

        [DisplayName("Datum rođenja")]
        public DateTimeOffset DateOfBirth { get; set; }

        [DisplayName("Kontakt")]
        public string Kontakt { get; set; }

        [DisplayName("Id članarine")]
        public int IdClanarine { get; set; }

        [DisplayName("Naziv članarine")]
        public string NazivClanarine { get; set; }
    }
}
