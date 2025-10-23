using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_oop
{
    public class Borrow
    {
        private Inventory inventory;

        public Borrow(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public void BorrowBook()
        {
            Console.Write("Enter serial code of book to borrow: ");
            string serial = Console.ReadLine();

            var book = inventory.FindBook(serial);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            if (book.IsBorrowed)
            {
                Console.WriteLine("That book is already borrowed.");
            }
            else
            {
                book.IsBorrowed = true;
                Console.WriteLine($"You borrowed '{book.Title}' successfully!");
            }
        }
    }
}
