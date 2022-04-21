using System;
using Address_Book;
class program
{
    public static void Main(String[] args)
    {
<<<<<<< Updated upstream
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
        

=======
        AddressBook contact = new AddressBook();

        Console.WriteLine("Welcome to Address Book Project");
        bool check = true;
        while (check)
        {
            Console.WriteLine("1.Add Contact\n2.Display Contact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    contact.AddContact();
                    break;
                case 2:
                    contact.Display();
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
>>>>>>> Stashed changes
    }

}