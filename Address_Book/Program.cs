using System;
using Address_Book;

class program
{
    
    public static void Main(String[] args)
    {
        Console.WriteLine("WelCome To Address Book");
        Contact aBook = new Contact();

        AddressBook book = new AddressBook();


        bool check = true;
        while (check)
        {
            Console.WriteLine("Select Number\n1.Add Contact\n2.Display Contact\n3.Update Contact\n4.Delete Contact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    book.addContact();
                    break;
                case 2:
                    book.Display();
                    break;
                case 3:
                    book.Update();
                    break;
                case 4:
                    book.Delete();
                    break;

                case 0:
                    check=false;
                    Console.WriteLine("Program Is Ended");
                    break;

            }
        }

    }

}