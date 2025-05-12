using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Entities.Models
{
    public class Airplane : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I'm a plane and I have a couple of wheels :)");
        }
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
