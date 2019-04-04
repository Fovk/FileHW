using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class TeamLeader : Iworker
    {
        public void DoWork(House house)
        {
            int j = 1;
            Console.WriteLine("Отчет строительства");
            foreach(Ipart i in house.House1)
            {
                if(i.IsReady==true){
                    Console.WriteLine("Сделано "+i.ToString()+" Этап Строительства " +j);
                    j++;
                }
            }
        }
    }
}
