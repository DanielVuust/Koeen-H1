using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Koeen
{
    class Operations
    {
        public Queue<Person> AddItem(Queue<Person> kø)
        {
            Console.WriteLine("Skriv navnet på den person du vil tilføje" );
            string navn = Console.ReadLine();
            Console.WriteLine("Skriv alderen på den person du vil tilføje");
            int alder = Convert.ToInt32(Console.ReadLine());
            kø.Enqueue(new Person(navn) { age = alder });
            return kø;
        }
        public Queue<Person> DeleteItem(Queue<Person> kø)
        {
            Console.WriteLine("Skriv navnet på den person du vil fjerne");
            string strPerson = Console.ReadLine();
            kø = new Queue<Person>(kø.Where(kø => kø.name != strPerson));
            return kø;
        }
        public void NumberOfItems(Queue<Person> kø)
        {
            Console.WriteLine(kø.Count);
        }
        public void MinAndMax(Queue<Person> kø)
        {
            Console.WriteLine($" First person: {kø.ToArray()[0].name} \n Last person: {kø.ToArray()[kø.Count -1].name}");
        }
        public void FindItem(Queue<Person> kø)
        {
            Console.WriteLine(" Skriv navnet på den person du vil finde");
            string strPerson = Console.ReadLine();
            var list = kø.Where(kø => kø.name == strPerson);
            foreach (Person person in list)
            {
                Console.WriteLine($" Navn: {person.name}\t Alder: {person.age}\t Dato: {person.date}");
            }
        }
        public void PrintAll(Queue<Person> kø)
        {
            foreach(Person person in kø)
            {
                Console.WriteLine($" Navn: {person.name}\t Alder: {person.age}\t Dato: {person.date}");
            }
        }
        
        
    }
}
