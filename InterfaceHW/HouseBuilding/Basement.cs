using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class Basement : Ipart
    {
        public bool IsReady { get; set; } = false;
        public Basement()
        {
            IsReady = false;
        }
    }
}
