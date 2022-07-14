using System.Text;

namespace ClassesAndObjects
{
    class Program
    {

        static void Main(string[] args)
        {

            Book book1 = new Book("Harry Potter", "JKRowling",400);
            Book book2 = new Book("Lord Angga", "Tolkeir", 700);
            Book book3 = new Book();
            book2.title = "The Habbit";

            Console.WriteLine(book2.title);
            Console.ReadLine();
        }
    }
}