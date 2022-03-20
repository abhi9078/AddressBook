using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace AddressBookManagement
{

    public class Person
    {
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string City;
        public string State;
        public int PostalCode;
        public long PhoneNumber;
        public string Email;

        public string Result()
        {
            return "\nName is: " + First_Name +" "+ Last_Name + "\nAddress: " + Address + "\nCity is " + City +
                "\nState is " + State + "\nPostal code is: " + PostalCode + "\nPhone: " + PhoneNumber + "\nEmail is " + Email;
        }
    }

    public class Person2
    {
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string City;
        public string State;
        public int PostalCode;
        public long PhoneNumber;
        public string Email;

        public string Result2()
        {
            return "\nName is: " + First_Name + " " + Last_Name + "\nAddress: " + Address + "\nCity is " + City +
                "\nState is " + State + "\nPostal code is: " + PostalCode + "\nPhone: " + PhoneNumber + "\nEmail is " + Email;
        }
    }

    public class Person3
    {
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string City;
        public string State;
        public int PostalCode;
        public long PhoneNumber;
        public string Email;

        public string Result3()
        {
            return "\nName is: " + First_Name + " " + Last_Name + "\nAddress: " + Address + "\nCity is " + City +
                "\nState is " + State + "\nPostal code is: " + PostalCode + "\nPhone: " + PhoneNumber + "\nEmail is " + Email;
        }
    }

    //First AddressBook
    internal class AddressBook1
    {
        public List<Person> person = new List<Person>();

        public void Display()
        {
            Console.WriteLine("\nAddressBook is: ");
            foreach (Person per in person)
            {
                Console.WriteLine(per.Result());
            }
        }

        public void addPerson(Person p)
        {
            person.Add(p);
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"D:\.Net\Assignment\day10\AddressBookManagement\AddressBookManagement\result.json", jsonData);
        }

        public AddressBook1()
        {
            string json = File.ReadAllText(@"D:\.Net\Assignment\day10\AddressBookManagement\AddressBookManagement\result.json");
            if (json.Length > 0)
            {
                person = JsonConvert.DeserializeObject<List<Person>>(json);
            }
            else
                person = new List<Person>();
        }

        public void EditPerson(string First_Name)
        {
            for (int i = 0; i < person.Count; i++)
            {
                if (person[i].First_Name == First_Name)
                {
                    Console.WriteLine("Enter First Name: ");
                    person[i].First_Name = Console.ReadLine();
                    Console.WriteLine("Enter Last Name: ");
                    person[i].Last_Name = Console.ReadLine();
                    Console.WriteLine("Enter Address ");
                    person[i].Address = Console.ReadLine();
                    Console.WriteLine("Enter City: ");
                    person[i].City = Console.ReadLine();
                    Console.WriteLine("Enter State: ");
                    person[i].State = Console.ReadLine();
                    Console.WriteLine("Enter pin code: ");
                    person[i].PostalCode= int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number: ");
                    person[i].PhoneNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Email id: ");
                    person[i].Email = Console.ReadLine();
                }
            }
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"D:\.Net\Assignment\day10\AddressBookManagement\AddressBookManagement\result.json", jsonData);
        }

        public void Remove(string First_Name)
        {
            Person pers = null;
            foreach (Person p in person)
            {
                if (p.First_Name == First_Name)
                {
                    pers = p;
                }
            }
            person.Remove(pers);
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"D:\.Net\Assignment\day10\AddressBookManagement\AddressBookManagement\result.json", jsonData);
        }


    }

    //Second Address Book
    internal class AddressBook2
    {
        public List<Person2> person2 = new List<Person2>();

        public void Display()
        {
            Console.WriteLine("\nAddressBook is: ");
            foreach (Person2 per in person2)
            {
                Console.WriteLine(per.Result2());
            }
        }

        public void addPerson(Person2 p2)
        {
            person2.Add(p2);
            string jsonData = JsonConvert.SerializeObject(person2);
            File.WriteAllText(@"D:\.Net\Assignment\day10\AddressBookManagement\AddressBookManagement\AddressBook2.json", jsonData);
        }

        public AddressBook2()
        {
            string json = File.ReadAllText(@"D:\.Net\Assignment\day10\AddressBookManagement\AddressBookManagement\AddressBook2.json");
            if (json.Length > 0)
            {
                person2 = JsonConvert.DeserializeObject<List<Person2>>(json);
            }
            else
                person2 = new List<Person2>();
        }

        public void EditPerson(string First_Name)
        {
            for (int i = 0; i < person2.Count; i++)
            {
                if (person2[i].First_Name == First_Name)
                {
                    Console.WriteLine("Enter First Name: ");
                    person2[i].First_Name = Console.ReadLine();
                    Console.WriteLine("Enter Last Name: ");
                    person2[i].Last_Name = Console.ReadLine();
                    Console.WriteLine("Enter Address ");
                    person2[i].Address = Console.ReadLine();
                    Console.WriteLine("Enter City: ");
                    person2[i].City = Console.ReadLine();
                    Console.WriteLine("Enter State: ");
                    person2[i].State = Console.ReadLine();
                    Console.WriteLine("Enter pin code: ");
                    person2[i].PostalCode = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number: ");
                    person2[i].PhoneNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Email id: ");
                    person2[i].Email = Console.ReadLine();
                }
            }
            string jsonData = JsonConvert.SerializeObject(person2);
            File.WriteAllText(@"D:\.Net\Assignment\day10\AddressBookManagement\AddressBookManagement\AddressBook2.json", jsonData);
        }

        public void Remove(string First_Name)
        {
            Person2 pers = null;
            foreach (Person2 p2 in person2)
            {
                if (p2.First_Name == First_Name)
                {
                    pers = p2;
                }
            }
            person2.Remove(pers);
            string jsonData = JsonConvert.SerializeObject(person2);
            File.WriteAllText(@"D:\.Net\Assignment\day10\AddressBookManagement\AddressBookManagement\AddressBook2.json", jsonData);
        }

    }

    //Third AddressBook
    internal class AddressBook3
    {
        public List<Person3> person = new List<Person3>();

        public void Display()
        {
            Console.WriteLine("\nAddressBook is: ");
            foreach (Person3 per in person)
            {
                Console.WriteLine(per.Result3());
            }
        }

        public void addPerson(Person3 p3)
        {
            person.Add(p3);
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"D:\.Net\Assignment\day10\AddressBookManagement\AddressBookManagement\AddressBook2.json", jsonData);
        }

        public AddressBook3()
        {
            string json = File.ReadAllText(@"D:\.Net\Assignment\day10\AddressBookManagement\AddressBookManagement\AddressBook3.json");
            if (json.Length > 0)
            {
                person = JsonConvert.DeserializeObject<List<Person3>>(json);
            }
            else
                person = new List<Person3>();
        }

        public void EditPerson(string First_Name)
        {
            for (int i = 0; i < person.Count; i++)
            {
                if (person[i].First_Name == First_Name)
                {
                    Console.WriteLine("Enter First Name: ");
                    person[i].First_Name = Console.ReadLine();
                    Console.WriteLine("Enter Last Name: ");
                    person[i].Last_Name = Console.ReadLine();
                    Console.WriteLine("Enter Address ");
                    person[i].Address = Console.ReadLine();
                    Console.WriteLine("Enter City: ");
                    person[i].City = Console.ReadLine();
                    Console.WriteLine("Enter State: ");
                    person[i].State = Console.ReadLine();
                    Console.WriteLine("Enter pin code: ");
                    person[i].PostalCode = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number: ");
                    person[i].PhoneNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Email id: ");
                    person[i].Email = Console.ReadLine();
                }
            }
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"D:\.Net\Assignment\day10\AddressBookManagement\AddressBookManagement\AddressBook3.json", jsonData);
        }

        public void Remove(string First_Name)
        {
            Person3 pers = null;
            foreach (Person3 p3 in person)
            {
                if (p3.First_Name == First_Name)
                {
                    pers = p3;
                }
            }
            person.Remove(pers);
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"D:\.Net\Assignment\day10\AddressBookManagement\AddressBookManagement\AddressBook3.json", jsonData);
        }


    }

}
