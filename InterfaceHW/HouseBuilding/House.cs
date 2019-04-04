using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class House
    {
        public List<Ipart> House1 { get; set; }
        public House()
        {
            House1 = new List<Ipart>();
        }
    }
}
