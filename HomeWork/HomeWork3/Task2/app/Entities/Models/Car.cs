using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Entities.Models
{
    public class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a car and I drive on 4 wheels :)");
        }
        public void Drive()
        {
            Console.WriteLine("Driving");
        }
    }
}
