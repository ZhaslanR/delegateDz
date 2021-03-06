﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Bus : Cars
    {
        public const int maxSpeed = 5;

        public Bus(string name = "") : base()
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
