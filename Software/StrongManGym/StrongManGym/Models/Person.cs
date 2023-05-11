using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongManGym.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        [DisplayName("Ime")]
        public string FirstName { get; set; }
        [DisplayName("Prezime")]
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
