using System;

namespace AddressBookManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook Program");

            /*UC_Program uC_1 = new UC_Program();
            Person person = new Person();
            person.First_Name = "Abhilash";
            person.Last_Name = "Meher";
            person.Address = "Odisha";
            person.City = "Balangir";
            person.State = "Odisha";
            person.PostalCode = 767025;
            person.PhoneNumber = 4578632;
            person.Email = "abhilashmeher1234@gmail.com";
            uC_1.addPerson(person);
            uC_1.Display();*/

           /* UC_Program uC_2 = new UC_Program();
            Person person = new Person();
            Console.WriteLine("Enter First Name: ");
            string fname = Console.ReadLine();
            person.First_Name = fname;
            Console.WriteLine("Enter Last Name: ");
            string lname = Console.ReadLine();
            person.Last_Name = lname;
            Console.WriteLine("Enter Address ");
            string address = Console.ReadLine();
            person.Address = address;
            Console.WriteLine("Enter City: ");
            string city = Console.ReadLine();
            person.City = city;
            Console.WriteLine("Enter State: ");
            string state = Console.ReadLine();
            person.State = state;
            Console.WriteLine("Enter pin code: ");
            int pin = int.Parse(Console.ReadLine());
            person.PostalCode = pin;
            Console.WriteLine("Enter Phone Number: ");
            long number = long.Parse(Console.ReadLine());
            person.PhoneNumber = number;
            Console.WriteLine("Enter Email id: ");
            string email = Console.ReadLine();
            person.Email = email;
            uC_2.addPerson(person);
            uC_2.Display();*/

           /* UC_Program uc_3 = new UC_Program();
            uc_3.Display();
            Console.WriteLine("Enter First name to Edit that particular Item: ");
            string name=Console.ReadLine();
            uc_3.EditPerson(name);
            uc_3.Display();*/

           /* UC_Program uc_4 = new UC_Program();
            uc_4.Display();
            Console.WriteLine("Enter First name to Delete that particular Item: ");
            string name = Console.ReadLine();
            uc_4.Remove(name);
            uc_4.Display();*/

            UC_Program uc_5 = new UC_Program();
            
            while (true)
            {
                Console.WriteLine("\nSelect Any one Operation: ");
                Console.WriteLine("1. To Add New Person: ");
                Console.WriteLine("2. To Display Contacts: ");
                int read = int.Parse(Console.ReadLine());
                switch (read)
                {
                    case 1:
                        Person person = new Person();
                        Console.WriteLine("Enter First Name: ");
                        string fname = Console.ReadLine();
                        person.First_Name = fname;
                        Console.WriteLine("Enter Last Name: ");
                        string lname = Console.ReadLine();
                        person.Last_Name = lname;
                        Console.WriteLine("Enter Address ");
                        string address = Console.ReadLine();
                        person.Address = address;
                        Console.WriteLine("Enter City: ");
                        string city = Console.ReadLine();
                        person.City = city;
                        Console.WriteLine("Enter State: ");
                        string state = Console.ReadLine();
                        person.State = state;
                        Console.WriteLine("Enter pin code: ");
                        int pin = int.Parse(Console.ReadLine());
                        person.PostalCode = pin;
                        Console.WriteLine("Enter Phone Number: ");
                        long number = long.Parse(Console.ReadLine());
                        person.PhoneNumber = number;
                        Console.WriteLine("Enter Email id: ");
                        string email = Console.ReadLine();
                        person.Email = email;
                        uc_5.addPerson(person);
                        break;

                    case 2:
                        uc_5.Display();
                        break;
                }
            }

        }
    }
}
