using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLJsonHW
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public Car()
        {
            Id = Guid.NewGuid();
        }
    }
}
