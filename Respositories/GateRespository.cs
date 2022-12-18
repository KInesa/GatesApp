using GatesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatesApp.Respositories
{
    public class GateRespository 
    {
        private List<Gates> gates = new List<Gates>();

        public GateRespository()
        {
            gates.Add(new Gates(1, "North gate"));
            gates.Add(new Gates(2, "East gate"));
            gates.Add(new Gates(3, "South gate"));
            gates.Add(new Gates(4, "West gate"));
        }

        public Gates GetGates(int id)
        {
            var currentGate = gates.FirstOrDefault(x => x.Id == id);

            return currentGate;

        }
    }
}
