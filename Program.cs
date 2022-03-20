using System;

namespace AddressBookManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To AddressBook Program");
            //UC_1 Program
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

            //UC_2 program
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

            //UC_3 program
            /* UC_Program uc_3 = new UC_Program();
             uc_3.Display();
             Console.WriteLine("Enter First name to Edit that particular Item: ");
             string name=Console.ReadLine();
             uc_3.EditPerson(name);
             uc_3.Display();*/

            //UC_4 program
            /* UC_Program uc_4 = new UC_Program();
             uc_4.Display();
             Console.WriteLine("Enter First name to Delete that particular Item: ");
             string name = Console.ReadLine();
             uc_4.Remove(name);
             uc_4.Display();*/

            //UC_5 program
            /*UC_Program uc_5 = new UC_Program();
            
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
            }*/

            //UC_6 program
            Console.WriteLine("Please Select Any one AddressBook");
            Console.WriteLine("1. Address Book 1");
            Console.WriteLine("2. Address Book 2");
            Console.WriteLine("3. Address Book 3");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    
                        AddressBook1 ad1 = new AddressBook1();
                        Console.WriteLine("Welcome to Address BOOK 1");
                        while (true)
                        {
                            Console.WriteLine("\nSelect Any one Operation: ");
                            Console.WriteLine("1. To Add New Person: ");
                            Console.WriteLine("2. To Display Contacts: ");
                            Console.WriteLine("3. To Edit any Contacts: ");
                            Console.WriteLine("4. To Delete any Contacts: ");
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
                                    ad1.addPerson(person);
                                    break;

                                case 2:
                                    ad1.Display();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter First name to Edit that particular Item: ");
                                    string name = Console.ReadLine();
                                    ad1.EditPerson(name);
                                    break;
                                case 4:
                                    Console.WriteLine("Enter First name to Delete that particular Item: ");
                                    string name1 = Console.ReadLine();
                                    ad1.Remove(name1);
                                    break;
                                default:
                                    Console.WriteLine("Please Select the proper operation");
                                    break;
                            }
                        }
                        break;
                    
                case 2:
                    AddressBook2 ad2 = new AddressBook2();
                    Console.WriteLine("Welcome to Address BOOK 2");
                    while (true)
                    {
                        Console.WriteLine("\nSelect Any one Operation: ");
                        Console.WriteLine("1. To Add New Person: ");
                        Console.WriteLine("2. To Display Contacts: ");
                        Console.WriteLine("3. To Edit any Contacts: ");
                        Console.WriteLine("4. To Delete any Contacts: ");
                        int read = int.Parse(Console.ReadLine());
                        switch (read)
                        {
                            case 1:
                                Person2 person2 = new Person2();
                                Console.WriteLine("Enter First Name: ");
                                string fname = Console.ReadLine();
                                person2.First_Name = fname;
                                Console.WriteLine("Enter Last Name: ");
                                string lname = Console.ReadLine();
                                person2.Last_Name = lname;
                                Console.WriteLine("Enter Address ");
                                string address = Console.ReadLine();
                                person2.Address = address;
                                Console.WriteLine("Enter City: ");
                                string city = Console.ReadLine();
                                person2.City = city;
                                Console.WriteLine("Enter State: ");
                                string state = Console.ReadLine();
                                person2.State = state;
                                Console.WriteLine("Enter pin code: ");
                                int pin = int.Parse(Console.ReadLine());
                                person2.PostalCode = pin;
                                Console.WriteLine("Enter Phone Number: ");
                                long number = long.Parse(Console.ReadLine());
                                person2.PhoneNumber = number;
                                Console.WriteLine("Enter Email id: ");
                                string email = Console.ReadLine();
                                person2.Email = email;
                                ad2.addPerson(person2);
                                break;

                            case 2:
                                ad2.Display();
                                break;
                            case 3:
                                Console.WriteLine("Enter First name to Edit that particular Item: ");
                                string name = Console.ReadLine();
                                ad2.EditPerson(name);
                                break;
                            case 4:
                                Console.WriteLine("Enter First name to Delete that particular Item: ");
                                string name1 = Console.ReadLine();
                                ad2.Remove(name1);
                                break;
                            default:
                                Console.WriteLine("Please Select the proper operation");
                                break;
                        }
                    }
                    break;

                case 3:
                    AddressBook3 ad3 = new AddressBook3();
                    Console.WriteLine("Welcome to Address BOOK 3");
                    while (true)
                    {
                        Console.WriteLine("\nSelect Any one Operation: ");
                        Console.WriteLine("1. To Add New Person: ");
                        Console.WriteLine("2. To Display Contacts: ");
                        Console.WriteLine("3. To Edit any Contacts: ");
                        Console.WriteLine("4. To Delete any Contacts: ");
                        int read = int.Parse(Console.ReadLine());
                        switch (read)
                        {
                            case 1:
                                Person3 person = new Person3();
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
                                ad3.addPerson(person);
                                break;

                            case 2:
                                ad3.Display();
                                break;
                            case 3:
                                Console.WriteLine("Enter First name to Edit that particular Item: ");
                                string name = Console.ReadLine();
                                ad3.EditPerson(name);
                                break;
                            case 4:
                                Console.WriteLine("Enter First name to Delete that particular Item: ");
                                string name1 = Console.ReadLine();
                                ad3.Remove(name1);
                                break;
                            default:
                                Console.WriteLine("Please Select the proper operation");
                                break;
                        }
                    }
                    break;

                    default :
                    Console.WriteLine("Please select any one operation ");
                    break;
            }
        }
    }
}
