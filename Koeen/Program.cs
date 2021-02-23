using System;
using System.Collections.Generic;

namespace Koeen
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Person> kø = new Queue<Person>();

            kø.Enqueue(new Person("Daniel") { age = 17 });
            kø.Enqueue(new Person("Perter") { age = 21 });
            kø.Enqueue(new Person("Han") { age = 25 });

            Operations operations = new Operations();
            while (true)
            {
                Console.WriteLine(" 1. Add items \n 2. Delete items \n 3.Show the number of items \n 4.Show min and max items \n 5.Find an item \n 6.Print all items \n 7.Exit \n\n Enter your choice: ");
                string strValg = Console.ReadLine();
                Console.WriteLine();
                switch (strValg)
                {
                    case "1":
                        kø = operations.AddItem(kø);
                        break;
                    case "2":
                        kø = operations.DeleteItem(kø);
                        break;
                    case "3":
                        operations.NumberOfItems(kø);
                        break;
                    case "4":
                        operations.MinAndMax(kø);
                        break;
                    case "5":
                        operations.FindItem(kø);
                        break;
                    case "6":
                        operations.PrintAll(kø);
                        break;
                    case "7":
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Du har ikke intastet et gyldigt tal prøv igen");
                        continue;
                }
                Console.WriteLine();
            }
        }
    }
}
