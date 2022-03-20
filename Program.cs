using System;

namespace AddressBookManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook Program");

            UC_Program uC_1 = new UC_Program();
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
            uC_1.Display();
        }
    }
}
