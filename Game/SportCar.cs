using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class SportCar : Cars
    {
        public const int maxSpeed = 15;

        public SportCar(string name = "") : base()
        {
            Name = name;
        }

        public override void ChangeSpeed()
        {
            Random rand = new Random();
            Speed = rand.Next(minSpeed, maxSpeed);
        }

    }
}
