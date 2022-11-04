using System;

namespace Repitisjon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("The Hobbit", "Tolkein", 600);
            Book book2 = new Book("Blindsonen", "Per Eftang", 140);

            
            


            Console.WriteLine(book1.title + ", " + book1.author);
            Console.WriteLine("Is this book long?" + book1.IsLong());
            Console.WriteLine(book2.title + ", " + book2.author);
            Console.WriteLine("Is this book long?" + book2.IsLong());
            Console.ReadLine();
        }
    }
}
