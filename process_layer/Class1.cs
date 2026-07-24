using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDTO;

namespace process_layer
{
    public static class process
    {
        public static void show(ClsDTO car)
        {
            car._fill(car);
            Console.WriteLine($"traffic fine for vehicle {car.plate_number}");
            Console.WriteLine($"total amount {car.total_amount}");
            Console.WriteLine("voilations: ");
            foreach (string x in car .violations)
            {
                if(x== "seatbelt")
                    Console.WriteLine($"seatbelt not fastned: {ClsDTO.fees[x]}");
                if(x=="speed")
                    Console.WriteLine($"speed of {car.speed} exceed max allowed {car.max_speed} : {ClsDTO.fees[x]}");
            }
        }
    }
}
