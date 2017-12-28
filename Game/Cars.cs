using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public delegate void Finish(Cars cars);
    public abstract class Cars
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Position { get; private set; }

        public event Finish finish;
        public const int minSpeed = 1;
        public const int finishLine = 100;
        public abstract void ChangeSpeed();

        public Cars()
        {
            Position = 0;
            ChangeSpeed();
        }

        public bool Run()
        {
            Position += Speed;
            ChangeSpeed();
            if (Position >= finishLine)
            {
                finish(this);
                return true;
            }
            return false;
        }

        public void Show()
        {
            Console.WriteLine("Имя: {0}\nСкорост: {1}\nПозиция: {2}", Name, Speed, Position);
        }
    }
}
