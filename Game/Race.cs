using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Race
    {
        public Finish finish = cars =>
        {
            Console.WriteLine("Победила машина: " + cars.Name);
        };

        public List<Cars> Carss { get; set; }

        public Race()
        {
            Carss = new List<Cars>();
        }
        

        public bool MoveAll()
        {
            for (int i = 0; i < Carss.Count; i++)
            {
                if (Carss[i].Run())
                {
                    Console.WriteLine("Гонки завершены!");
                    Сlearing();
                    return true;
                }
            }
            return false;
        }

        public void StartGame()
        {
            Carss.ForEach(car => car.finish += finish);
        }
        private void Сlearing()
        {
            Carss.Clear();
        }
    }
}
