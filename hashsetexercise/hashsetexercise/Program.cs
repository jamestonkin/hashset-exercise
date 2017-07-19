using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashsetexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showRoom = new HashSet<string>();

            showRoom.Add("Toyota");
            showRoom.Add("Nissan");
            showRoom.Add("Ford");
            showRoom.Add("Hyundai");

            Console.Write(showRoom.Count);

            showRoom.Add("Ford");

            foreach (string model in showRoom) {
                Console.Write("\n" + model);
            }

            HashSet<string> usedLot = new HashSet<string>();

            usedLot.Add("Chevrolet");
            usedLot.Add("Jeep");

            showRoom.UnionWith(usedLot);
            foreach (string model in showRoom)
            {
                Console.Write("\n" + model);
            }

            showRoom.Remove("Ford");
            foreach (string model in showRoom)
            {
                Console.Write("\n" + model);
            }

            HashSet<string> junkYard = new HashSet<string>();

            junkYard.Add("Porsche");
            junkYard.Add("Ferrari");
            junkYard.Add("BMW");
            junkYard.Add("Chevrolet");
            junkYard.Add("Hyundai");

            showRoom.IntersectWith(junkYard);
            foreach (string same in showRoom)
            {
                Console.Write("\n" + same);
            }

            showRoom.UnionWith(junkYard);
            showRoom.Remove("BMW");

            Console.Write("\nMy Cars Now:");
            foreach (string mycars in showRoom)
            {
                Console.Write("\n" + mycars);
            }

            Console.Read();
        }
    }
}
