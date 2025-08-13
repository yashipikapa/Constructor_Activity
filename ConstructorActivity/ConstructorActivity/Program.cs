// Julia Yashika A. Kong & Kyla Marie Caballero  BSIT-2

using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Book 1: Default Constructor ---");
        Book book1 = new Book();
        book1.DisplayBookInfo();

        Console.WriteLine("\n--- Book 2: Basic Constructor ---");
        Book book2 = new Book("Pride and Prejudice", "Jane Austen");
        book2.DisplayBookInfo();

        Console.WriteLine("\n--- Book 3: Detailed Constructor ---");
        Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);
        book3.DisplayBookInfo();

        Console.WriteLine("\n--- Book 4: Complete Constructor ---");
        Book book4 = new Book("Dune", "Frank Herbert", 1965, "Science Fiction");
        book4.DisplayBookInfo();
    }
}