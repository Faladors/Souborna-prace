using System;

namespace Souborná_práce
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dam = 0;
            while (Dam <=0)
            {
                Console.WriteLine("Tento pogram umožnuje generovat Tetranacciho posloupnost.");
                Console.WriteLine("Vložte délku sekvence(min. 12):");
                int size = int.Parse(Console.ReadLine());
                if (size >= 12)
                {
                    Console.WriteLine("Vložte čísla:");
                    int a = int.Parse(Console.ReadLine());

                    int b = int.Parse(Console.ReadLine());

                    int c = int.Parse(Console.ReadLine());

                    int d = int.Parse(Console.ReadLine());

                    int e = a + b + c + d;

                    Console.WriteLine("zadaná čísla sekvence:");
                    Console.Write(a + " " + b + " " + c + " " + d);
                    Console.WriteLine(" ");
                    Console.WriteLine("sekvence:");

                    for (int i = 0; i < size; i++)
                    {
                        Console.Write(e + " ");
                        a = b;
                        b = c;
                        c = d;
                        d = e;
                        e = a + b + c + d;

                    }

                }
                else
                    Console.WriteLine("Zadejte číslo větší jak 12");

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Stiskněte 1 pro ukončení programu");
                Console.WriteLine("Stiskněte 2 pro opakování programu");
                int dam1 = int.Parse(Console.ReadLine());
                if (dam1 <= 1)
                    Dam = 1;
                Console.WriteLine(" ");
            }   

            Console.ReadKey();

            
        }
    }
}