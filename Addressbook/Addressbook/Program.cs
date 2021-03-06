using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook
{
    public class Program
    {
        public static string bookName = "Default";
        public static string bookName1 = "xyz";


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Progam \n");

            CreateAddressBook addressBook = new CreateAddressBook();
            addressBook.AddAddressBook("Default");
            addressBook.AddAddressBook("xyz");
            addressBook.AddContactDetails("Raji", "Gandi", "Warangal", "Warangal", "Telangana", 506381, 9999955555, "raji26@gmail.com","Default");
            addressBook.AddContactDetails("Yash", "Gandi", "Warangal", "Warangal", "Telangana", 506380, 685799999, "yash24@gmail.com","Default");
            addressBook.AddContactDetails("Bujji", "Gandi", "hnk", "hnk", "Telangana", 506001, 9999999999, "bujji02@gmail.com", "Default");
            addressBook.AddContactDetails("Mani", "Gandi", "Kmm","Kmm", "Telangana", 506003, 8888999999, "mani04@gmail.com", "xyz");


        start:
            Console.WriteLine("Please choose an option from the below list");
            Console.WriteLine("\n1. Add New Address Book \n2. Add New Contact \n3. View Contacts \n4. View Contact by Person \n5. Edit Contact \n6. Delete Contact \n7. View all AddressBooks \n8. Switch AddressBook \n9.SearchPerson By City or State\n10.view person by city or state\n11.Number of person by city or state \n12.Sort By Person Alphabetically \n13.Sort by city-state-zip\n14. write to file \n15. Read from file\n16. Write to Csv file \n17. Read from CSV file \n18.Exit\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter Unique Address Book Name to create: ");
                    string newBookName = Console.ReadLine();
                    addressBook.AddAddressBook(newBookName);
                    if (addressBook.CheckAddressBook(newBookName) == newBookName)
                    {
                        bookName = newBookName;
                        Console.WriteLine($"Switched to: {bookName}");
                    }
                    break;
                case 2:
                    addressBook.AddNewContact(bookName);
                    break;
                case 3:
                    addressBook.ViewContacts(bookName);
                    break;
                case 4:
                    Console.WriteLine("Enter the First Name to View Contact Details: ");
                    string f_Name = Console.ReadLine();
                    addressBook.ViewContact(f_Name, bookName,bookName1);
                    break;
                case 5:
                    Console.WriteLine("Enter the First Name to Edit Contact Details: ");
                    string input = Console.ReadLine();
                    addressBook.EditContact(input, bookName);
                    addressBook.ViewContact(input, bookName,bookName1);
                    break;
                case 6:
                    Console.WriteLine("Enter the First Name of Contact: ");
                    string fName = Console.ReadLine();
                    Console.WriteLine("Enter the Last Name to Delete Contact: ");
                    string lName = Console.ReadLine();
                    addressBook.DeleteContact(fName, lName, bookName);
                    break;
                case 7:
                    addressBook.ViewAddressBooks();
                    break;
                case 8:
                    Console.WriteLine("Enter the AddressBook Name to Switch into: ");
                    string adBookName = Console.ReadLine();
                    if (addressBook.CheckAddressBook(adBookName) == adBookName)
                    {
                        bookName = adBookName;
                        Console.WriteLine($"Switched to: {bookName}");
                    }
                    else
                        Console.WriteLine("AddressBook Not Found");
                    break;
                 case 9:
                    Console.WriteLine("Enter the city or state to Search person by city or state across addressbook: ");
                    string userData = Console.ReadLine();
                    addressBook.SearchPersonByCityOrState(userData);
                    break;
                case 10:
                    Console.WriteLine("View person by city or state across addressbook: ");
                    addressBook.ViewPersonByCityOrState();
                    break;
                case 11:
                    Console.WriteLine("person count by city or state: ");
                    addressBook.CountPersonByCityOrState();
                    break;
                case 12:
                    Console.WriteLine("\nSort by person Name:");
                    addressBook.SortByName(bookName);
                    break;
                case 13:
                    Console.WriteLine("Sort entries:");
                    addressBook.SortBy(bookName);
                    break;
                case 14:
                    addressBook.WriteToFile();
                    break;
                case 15:
                    addressBook.ReadFile();
                    break;
                case 16:
                    addressBook.WriteCsvFile();
                    break;
                case 17:
                    addressBook.ReadCsvFile();
                    break;
                case 18:
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

