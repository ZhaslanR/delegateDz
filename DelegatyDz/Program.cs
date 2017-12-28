using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game;

namespace DelegatyDz
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();
            bool IsStart = false;
            bool IsPlay = true;
            while(true)
            {
                if(IsStart)
                {
                    Console.Clear();
                    race.Carss.ForEach(car => Console.WriteLine(car));
                    Console.WriteLine("Нажмите ENTER");
                    Console.ReadLine();
                    if (race.MoveAll())
                    {
                        IsStart = false;
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1 - Добавить автобус");
                    Console.WriteLine("2 - Добавить грузовик");
                    Console.WriteLine("3 - Добавить легкое авто");
                    Console.WriteLine("4 - Добавить спортивную машину");

                    Console.WriteLine("0 - Начать гонку");
                    Console.Write("Выберите команду: ");

                    int pick;
                    while (!int.TryParse(Console.ReadLine(), out pick))
                    {
                        Console.WriteLine("Ошибка! Введите корректную цифру: ");
                    }

                    if (pick >= 1 && pick <= 4)
                    {
                        Console.Write("Введите название авто: ");
                        string name = Console.ReadLine();
                        switch (pick)
                        {
                            case 1: race.Carss.Add(new Bus(name)); break;
                            case 2: race.Carss.Add(new Truck(name)); break;
                            case 3: race.Carss.Add(new Car(name)); break;
                            case 4: race.Carss.Add(new SportCar(name)); break;
                        }
                    }
                    else if (pick == 0)
                    {
                        IsStart = true;
                        race.StartGame();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Некорректная цифра");
                        Console.ReadLine();
                    }
                }
            }

        }
    }
}
