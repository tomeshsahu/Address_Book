using System;
using Address_Book;
class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the Address Details");
        Contact contact = new Contact();
        Console.WriteLine("Enter FirstName");
        contact.FirstName = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter LastName");
        contact.LastName = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter Address");
        contact.Address = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter City");
        contact.City = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter State");
        contact.State = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter Zip");
        contact.Zip = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Phone Number");
        contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Enter Email");
        contact.Email = Convert.ToString(Console.ReadLine());

    }
}