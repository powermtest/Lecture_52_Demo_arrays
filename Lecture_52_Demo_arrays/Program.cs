using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_52_Demo_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {3, 7, 9, 14, 2, 6};
            
            //Length
            Console.WriteLine("Dlugosc: " +numbers.Length);

            Console.WriteLine("-------------");

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("na jakiej pozycji jest 9? " +(index+1));

            Console.WriteLine("-------------");

            //Clear()
            Array.Clear(numbers,0,2);
            //Metoda "Clear" zeruje elementy
            Console.WriteLine("Po czyszczeniu zostaly: ");
            foreach (var VARIABLE in numbers)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine("-------------");

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers,another,3);
            Console.WriteLine("Skopiowane elementy do tablicy another: ");
            foreach (var VARIABLE in another)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine("-------------");

            //Sort()
            Array.Sort(numbers);

            Console.WriteLine("Efekt sortowania tablicy numbers:");
            foreach (var VARIABLE in numbers)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine("-------------");

            //Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Efekt odwrocenia tablicy numbers:");
            foreach (var VARIABLE in numbers)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine("-------------");
        }
    }
}
