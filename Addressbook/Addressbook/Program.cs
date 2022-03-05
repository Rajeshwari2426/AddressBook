using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Progam \n");

            CreateAddressBook addressBook = new CreateAddressBook();
            addressBook.AddContactDetails("Raji", "Gandi", "Warangal", "Warangal", "Telangana", 506381, 9999955555, "raji26@gmail.com");
            start:
            Console.WriteLine("Please choose an option from the below list");
            Console.WriteLine("\n 1. Add New Contact \n 2. View Contact \n 3. Edit Contact \n 4. Delete Contact \n5. Exit\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addressBook.AddNewContact();
                    break;
                case 2:
                    addressBook.ViewContact();
                    break;
                case 3:
                    Console.WriteLine("Enter the First Name to Edit: ");
                    string input = Console.ReadLine();
                    addressBook.EditContact(input);
                    addressBook.ViewContact();
                    break;
                case 4:
                    Console.WriteLine("Enter the First Name of Contact: ");
                    string fName = Console.ReadLine();
                    Console.WriteLine("Enter the Last Name to Delete Contact: ");
                    string lName = Console.ReadLine();
                    addressBook.DeleteContact(fName, lName);
                    addressBook.ViewContact();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please choose the correct option");
                   goto start;
            }

            Console.ReadLine();
        }
    }
    
}

