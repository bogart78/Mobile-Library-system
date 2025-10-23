using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_oop
{
    public class Return
    {
        private Inventory inventory;

        public Return(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public void ReturnBook()
        {
            Console.Write("Enter serial code of book to return: ");
            string serial = Console.ReadLine();

            var book = inventory.FindBook(serial);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            if (!book.IsBorrowed)
            {
                Console.WriteLine("That book wasn’t borrowed.");
            }
            else
            {
                book.IsBorrowed = false;
                Console.WriteLine($"You returned '{book.Title}' successfully!");
            }
        }
    }
}
