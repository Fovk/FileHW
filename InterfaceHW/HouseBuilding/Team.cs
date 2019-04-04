using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class Team
    {
        public List<Iworker> workers { get; set; }
        public Team()
        {
            workers = new List<Iworker>();
        }
        public void TeamWork(List<Iworker> workers,House house)
        {
            foreach(Iworker i in workers)
            {
                i.DoWork(house);
            }
        }
    }
}
