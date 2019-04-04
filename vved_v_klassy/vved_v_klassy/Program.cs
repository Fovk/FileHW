using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vved_v_klassy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Article ar = new Article();
            string startMark = "Ferrari";
            Car[] cars = new Car[5];
            cars[0] = new Car(4, "toyota", 15, 4, "Oil", 2.5, 1.3);
            cars[1] = new Car(4, startMark, 15, 4, "Oil", 2.5, 1.3);
            cars[2] = new Car(4, "lamborghini", 25, 4, "Oil", 8.5, 1.3);
            cars[3] = new Car(4, startMark, 15, 4, "Oil", 2.5, 1.3);
            cars[4] = new Car(4, "toyota", 15, 4, "Oil", 2.5, 1.3);
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].InfoMark();
            }

        }
    }
    public partial class Car
    {
        public void InfoMark()
        {
            Console.WriteLine(_mark);
        }
    }
}