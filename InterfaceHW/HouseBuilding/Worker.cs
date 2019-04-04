using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class Worker : Iworker
    {
        public void DoWork(House house)
        {
            foreach(Ipart i in house.House1)
            {
                if (i.IsReady == false)
                {
                    i.IsReady = true;
                    break;
                }
            }
        }
    }
}
