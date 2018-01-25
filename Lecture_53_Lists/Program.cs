using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_53_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1,2,3,4};
            numbers.Add(1);
            numbers.AddRange(new int[3] {5,6,7});
            foreach (var VARIABLE in numbers)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine("----------");

            Console.WriteLine("Indeks jedynki w liscie: " + numbers.IndexOf(1));
            Console.WriteLine("Indeks jedynki w liscie uzywajac LastIndexOf: " + numbers.LastIndexOf(1));

            Console.WriteLine("----------");

            Console.WriteLine("Policz elementy w liscie: " +numbers.Count);

            Console.WriteLine("----------");

            Console.WriteLine("Usuwamy wszystkie jedynki:");
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Jedynki usuniete!");

            Console.WriteLine("----------");

            Console.WriteLine("A teraz czyscimy liste zupelnie!");
            numbers.Clear();
            Console.WriteLine("aktualna liczba elementow: " + numbers.Count);

            Console.WriteLine("----------");


        }

    }
}
