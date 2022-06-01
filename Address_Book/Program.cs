
using System;
using Address_Book;
class program
{
    
    public static void Main(String[] args)
    {
        AddressBook contact = new AddressBook();

        Console.WriteLine("Welcome to Address Book Project");
        bool check = true;
        while (check)
        {
            Console.WriteLine("1.Add Contact\n2.Display Contact\n3.Update Contact\n4.Delete Contact\n5.Add New Contact\n6.Add Dictionery\n7.Display Dictionary\n8.Search By City & State\n9.Sorting IN Alfabetical\n10.Sorting According ToCity");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    contact.AddContact();
                    break;
                case 2:
                    contact.Display();
                    break;
                case 3:
                    contact.Update();
                    break;
                case 4:
                    contact.Delete();
                    break;
                case 5:
                    contact.AddDetails();
                    break;
                case 6:
                    Console.WriteLine("Enter FirstName ");
                    string name=Console.ReadLine();
                    contact.AddDictionary(name);
                    break;
                case 7:
                    Console.WriteLine("Enter Name to display data in dictionary: ");
                    string dictionary = Console.ReadLine();
                    contact.DisplayDictionary(dictionary);
                    break;

                case 8:
                    contact.SearchByCityState();
                    break;

                case 9:
                    contact.SortingDataByPersonName();
                    break;
                case 10:
                    contact.SortingDataByCityStateOrZip();
                    break;

                case 11:
                    contact.sorting();
                    break;

                case 0:
                    check = false;
                    break;

            }
        }


    }
}