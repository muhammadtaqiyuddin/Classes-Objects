using System.Text;

namespace ClassesAndObjects
{
    class Program
    {

        static void Main(string[] args)
        {

            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord Angga";
            book2.author = "Tolkeir";
            book2.pages = 700;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);
            Console.WriteLine("==============");
            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);

            Console.ReadLine();
        }
    }
}