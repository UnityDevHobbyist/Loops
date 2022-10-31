using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int end = 10;
            int[] ammo = { 6, 2, 25, 50, 10};

            Console.WriteLine("While Loop:");
            Console.WriteLine();

            while (i <= end)
            {
                Console.Write(i + ", ");
                i++;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("For Loop:");
            Console.WriteLine();

            for (i = 1; i <= end; i++)
                Console.Write(i + ", ");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Weapon Ammo:");
            Console.WriteLine();

            i = 0;
            end = ammo.Length;

            while(i < end)
            {
                if(i != ammo.Length - 1)
                    Console.Write("Weapon #" + i + " ammo: " + ammo[i] + ", ");
                else
                    Console.Write("Weapon #" + i + " ammo: " + ammo[i]);
                i++;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Read();
        }
    }
}
