using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongManGym.Repositories
{
    public class StatusClanarine
    {
        public int Id { get; set; }
        public string NazivClanarine { get; set; }

        public override string ToString()
        {
            return NazivClanarine;
        }
    }
    
}
