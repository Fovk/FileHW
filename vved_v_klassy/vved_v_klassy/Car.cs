using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vved_v_klassy
{
    public partial class Car
    {
        int _numberOfDoors;
        string _mark;
        int _wheelsSize;
        static int _numberWheels;
        static string _typeOfEngine;
        double _lengthCar;
        double _heightCar;
        public int Get_numberOfDoors()
        {
            return _numberOfDoors;
        }
        public void Set_numberOfDoors(int numberOfDoors)
        {
            _numberOfDoors = numberOfDoors;
        }
        static Car()
        {
            //тело статического метода
        }
        public Car() { }
        public Car(int numberOfDoors, string mark, int wheelsSize, int numberWheels, string typeOfEngine, double lengthCar, double heightCar)
        {
            _numberOfDoors = numberOfDoors;
            _mark = mark;
            _wheelsSize = wheelsSize;
            _numberWheels = numberWheels;
            _typeOfEngine = typeOfEngine;
            _lengthCar = lengthCar;
            _heightCar = heightCar;
        }
        public Car(int numberOfDoors, string mark, int wheelsSize, double lengthCar, double heightCar)
        {
            _numberOfDoors = numberOfDoors;
            _mark = mark;
            _wheelsSize = wheelsSize;
            _lengthCar = lengthCar;
            _heightCar = heightCar;
        }
        public bool marktoFerrari(ref string startMark)
        {
            if (string.IsNullOrEmpty(_mark))
            {
                _mark = "";
                return false;
            }

            startMark = _mark;
            return true;
        }
    }
}
