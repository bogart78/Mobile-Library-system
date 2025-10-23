using System;
using test_oop;

class MainProgram
{
    static void Main()
    {
        Inventory inventory = new Inventory();
        Borrow borrow = new Borrow(inventory);
        Return returnBook = new Return(inventory);

        // Sample data
        inventory.AddBook(new Book("00001", "The Hobbit"));
        inventory.AddBook(new Book("00002", "Dune"));
        inventory.AddBook(new Book("00003", "1984"));

        while (true)
        {
            Console.WriteLine("\n--- Library Menu ---");
            Console.WriteLine("1. View Inventory");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Return Book");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    inventory.DisplayBooks();
                    break;
                case "2":
                    borrow.BorrowBook();
                    break;
                case "3":
                    returnBook.ReturnBook();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}