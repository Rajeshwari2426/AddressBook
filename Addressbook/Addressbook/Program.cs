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
            addressBook.AddContact();
            Console.ReadLine();

        }
    }
}

