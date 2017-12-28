using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Car : Cars
    {
        public const int maxSpeed = 15;

        public Car(string name = "") : base()
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
