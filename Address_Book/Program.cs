using System;
using Address_Book;
class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the Address Details");

        AddressBook addressBook = new AddressBook();
        addressBook.Display();

    Contact address=new Contact ();
        address.FirstName =Console.ReadLine();
        address.LastName =Console.ReadLine();
        address.Address=Console.ReadLine();
        address.City = Console.ReadLine();
        address.State = Console.ReadLine();
        address.Zip =Convert.ToInt32(Console.ReadLine());
        address.PhoneNumber =Convert.ToInt64 (Console.ReadLine());
        address.Email = Console.ReadLine();
        Console.WriteLine(address.FirstName+" "+ address.LastName+" "+ address.Address+" "+ address.City+" "+ address.State+" "+ address.Zip+" "+ address.PhoneNumber+" " + address.Email);
        

    }
}