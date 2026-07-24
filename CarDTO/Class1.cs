using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CarDTO
{
    // we can use this class to transfare inforamtion between layers(presentation , bussiness, data)
    
    public class ClsDTO
    {
        //vehicle information
        public string type { get; set; }
        public int speed { get; set; }
        public int max_speed { get; set; }
        public string plate_number { get; set; }
        public bool seatbelt_status { get; set; }
        public DateTime date { get; set; }

        //for violations
        public int total_amount { get; set; }

        public List<string> violations { get; set; } = new List<string>();
        
        public static Dictionary<string, int> fees = new Dictionary<string, int>
        {
            {"speed",300 },
            {"seatbelt",100 }
        };
        public ClsDTO _fill(ClsDTO car)
        {
            switch(type)
            {
                case "car":
                    max_speed = 90;
                    break;
                case "truck":
                case "bus":
                    max_speed = 80;
                    break;
            }

            if (seatbelt_status == true)
            {
                violations.Add("seatbelt");
                total_amount += fees["seatbelt"];
            }
            if (type == "car" && speed > max_speed)
            {
                violations.Add("speed");
                total_amount += fees["speed"];
            }
            if ((type == "bus" || type == "truck") && speed > max_speed)
            {
                violations.Add("speed");
                total_amount += fees["speed"];
            }
            return car;
        }
        

    }
}
