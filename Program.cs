using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDTO;
using process_layer;

namespace FAWRY_assigment
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ClsDTO car = new ClsDTO();
            car.type = "car";
            car.date =new DateTime();
            car.speed = 99;
            car.plate_number = "QWE1477";
            car.seatbelt_status = true;
            process.show(car);
            Console.WriteLine();

            ClsDTO car2 = new ClsDTO();
            car2.type = "truck";
            car2.date = new DateTime();
            car2.speed = 100;
            car2.plate_number = "QWE1596";
            car2.seatbelt_status = false;
            process.show(car2);

        }
    }
}
