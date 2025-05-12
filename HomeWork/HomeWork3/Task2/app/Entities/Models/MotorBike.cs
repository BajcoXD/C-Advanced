using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Entities.Models
{
    public class MotorBike : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a motorbike and I drive on 2 wheels :)");
        }
        public void Wheelie()
        {
            Console.WriteLine("Driving on one wheel");
        }
    }
}
