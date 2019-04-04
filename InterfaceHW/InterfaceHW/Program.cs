using HouseBuilding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHW
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Predicate<Ipart> isPositive = delegate (Ipart x) { return x.IsReady == false; };
            Basement basement = new Basement();
            Wall wall1 = new Wall();
            Wall wall2 = new Wall();
            Wall wall3 = new Wall();
            Wall wall4 = new Wall();
            Door door = new Door();
            Roof roof = new Roof();
            Window window1 = new Window();
            Window window2 = new Window();
            Window window3 = new Window();
            Window window4 = new Window();
            Team team = new Team();
            Worker worker1 = new Worker();
            Worker worker2 = new Worker();
            TeamLeader teamLeader = new TeamLeader();
            house.House1.Add(basement);
            house.House1.Add(wall1);
            house.House1.Add(wall2);
            house.House1.Add(wall3);
            house.House1.Add(wall4);
            house.House1.Add(window1);
            house.House1.Add(window2);
            house.House1.Add(window3);
            house.House1.Add(window4);
            house.House1.Add(door);
            house.House1.Add(roof);
            team.workers.Add(worker1);
            team.workers.Add(worker2);
            team.workers.Add(teamLeader);
            while (house.House1.Exists(delegate (Ipart x) { return x.IsReady == false; }) == true)
            {
                team.TeamWork(team.workers, house);
            }
            Console.WriteLine("Строительство завершено");
            Console.WriteLine("\t  _");
            Console.WriteLine("\t"+@" / \");
            Console.WriteLine("\t____");
            Console.WriteLine("\t|  |");
            Console.WriteLine("\t____");
            Console.ReadLine();
        }
    }
}
