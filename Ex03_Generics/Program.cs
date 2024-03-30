using Ex03_Generics;

namespace Ex03
{
    class Program
    {
        public static void Main()
        {
            ///taks1
            ///

            //0
            Person? person = new();
            Console.WriteLine(person);

            //1
            Person.ChangeName("Kamil", "Kowalski", person);
            Console.WriteLine(person);

            //2
            Person copyPerson = person;
            Person.CreateNewPerson("Marcin", "Buk", ref person);
            Console.WriteLine($"{person} jest to inny objekt niz tez z wczesniej {copyPerson != person}");

            //3
            Person.DeletePerson(ref person);
            Console.WriteLine($"{person} - nic");

            ///taks2
            ///Zmiana w klasie Person pola klas z public na private

            //task3
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            QueueComposition queueComposition = new QueueComposition();
            queueComposition.Enqueue(1);
            queueComposition.Enqueue(2);
            queueComposition.Enqueue(3);
            queueComposition.Enqueue(4);
            queueComposition.Enqueue(5);
            Console.WriteLine(queueComposition.Dequeue());
            Console.WriteLine(queueComposition.Dequeue());
            Console.WriteLine(queueComposition.Dequeue());
            //internal class Queue<T>
            //zainicjalizowac z capacity 

        }
    }
}