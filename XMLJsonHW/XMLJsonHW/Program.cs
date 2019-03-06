using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


    namespace XMLJsonHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                Mark ="Lada",
                Model="Prius",
                Price=5000
            };
            XmlDocument xmlDoc = new XmlDocument();
            var rootElement = xmlDoc.CreateElement("car");
            var idElement = xmlDoc.CreateElement("Id");
            idElement.SetAttribute("type", "Guid");
            idElement.InnerText = car.Id.ToString();
            rootElement.AppendChild(idElement);
            var markElement = xmlDoc.CreateElement("Mark");
            markElement.InnerText = car.Mark;
            rootElement.AppendChild(markElement);
            var modelElement = xmlDoc.CreateElement("Model");
            modelElement.InnerText = car.Model;
            rootElement.AppendChild(modelElement);
            var priceElement = xmlDoc.CreateElement("Price");
            priceElement.InnerText = car.Price.ToString();
            rootElement.AppendChild(priceElement);
            xmlDoc.AppendChild(rootElement);
            xmlDoc.Save("cars.xml");
            
        }
    }
}
