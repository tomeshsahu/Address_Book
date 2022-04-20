using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class AddressBook
    {
        
        Contact contact = new Contact();

        public void addContact()
            
            {
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
            contact.PhoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Email");
            contact.Email = Convert.ToString(Console.ReadLine());
        }
       
        public void Display()
        {
                Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.Email + "\n" + contact.PhoneNumber + "\n" + contact.City + "\n" + contact
                    .State + "\n" + contact.Zip);
                Console.WriteLine("\n");
            
        }
        public void Update()
        {
            Console.WriteLine("Edit a contact list enter first name");
            string name = Console.ReadLine();
            if (contact.FirstName.Equals(name))
            {
                Console.WriteLine("Edit a Contact\n1.lastName\n2.Address\n3.City\n4.State\n5.Zip\n6.PhoneNumber\n7.Email");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        string lastName=Console.ReadLine();
                        contact.LastName = lastName;
                        break;
                    case 2:
                        string address=Console.ReadLine();
                        contact.Address = address;
                        break;
                    case 3:
                        string City = Console.ReadLine();
                        contact.City = City;
                        break;
                    case 4:
                        string State = Console.ReadLine();
                        contact.State = State;
                        break;
                    case 5:
                        int Zip = Convert.ToInt32(Console.ReadLine());
                        contact.Zip = Zip;
                        break;
                    case 6:
                        int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                        contact.PhoneNumber = PhoneNumber;
                        break;
                    case 7:
                        string Email = Console.ReadLine();
                        contact.Email = Email;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Name is Not Exist");
            }

        }
            

    }
}