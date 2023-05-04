using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongManGym.Models
{
    public class UlazIzlaz
    {
        public int IdUlazIzlaz { get; set; }
        public int IdClana { get; set; }
        public DateTime Ulaz { get; set; }
        public DateTime Izlaz { get; set; }
    }
}
