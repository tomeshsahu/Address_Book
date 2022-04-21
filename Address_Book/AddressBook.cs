﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace Address_Book
{
    public class AddressBook
    {
        List<Contact> addContact = new List<Contact>();
        public void AddContact()
        {

            Console.WriteLine("Enter the Address Details");

            Contact contact1 = new Contact()
            {
                FirstName = Convert.ToString(Console.ReadLine()),

                LastName = Convert.ToString(Console.ReadLine()),

                Address = Convert.ToString(Console.ReadLine()),

                City = Convert.ToString(Console.ReadLine()),

                State = Convert.ToString(Console.ReadLine()),

                Zip = Convert.ToInt32(Console.ReadLine()),

                PhoneNumber = Convert.ToInt64(Console.ReadLine()),

                Email = Convert.ToString(Console.ReadLine()),

            };
            Contact contact2 = new Contact()
            {
                FirstName = "Tomeshwar",

                LastName = "Sahu",

                Address = "Bhilai",

                City = "Bhilai",

                State = "CG",

                Zip = 490020,

                PhoneNumber = 82828883837,

                Email = "tomeshwar@com",

            };

            Contact contact3 = new Contact()
            {
                FirstName = "Govind",

                LastName = "Bhatt",

                Address = "Bhilai",

                City = "Bhilai",

                State = "CG",

                Zip = 490021,

                PhoneNumber = 82828883837,

                Email = "govind@gmail.com",

            };
            addContact.Add(contact1);
            addContact.Add(contact2);
            addContact.Add(contact3);
        }
        public void Display()
        {
            foreach (var contact in addContact)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.Zip + " " + contact.PhoneNumber + " " + contact.Email);
            }
        }


        public void Update()
        {
            foreach (var contact in addContact)
            {
                Console.WriteLine("Enter The Number First Name");
                string name = Convert.ToString(Console.ReadLine());

                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("1.LastName\n2.Address\n3.City\n4.State\n5.Pin\n6.PhoneNumber\n7.Email ");
                    int optionn = Convert.ToInt32(Console.ReadLine());
                    switch (optionn)
                    {
                        case 1:
                            Console.WriteLine("enter the last name you want to edit : ");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("enter the address you want to edit :");
                            contact.Address = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("enter the city: ");
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("enter the state you want to edit :");
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("enter the email you want to edit :");
                            contact.Email = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("enter the zip you want to edit :");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("enter the phone you want to edit :");
                            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Choose the right option : ");
                            break;
                    }


                }
                else
                {
                    Console.WriteLine("Name not Exist");
                }
                Display();
            }
        }


        public void Delete()
        {
            Contact d = new Contact();
            Console.WriteLine("Enter First Name");
            string name = Convert.ToString(Console.ReadLine());
            foreach (var contact in addContact)
            {
                if (contact.FirstName.Equals(name))
                {
                    d = contact;
                }
            }
            addContact.Remove(d);
            Display();

        }

        }
    }
}
