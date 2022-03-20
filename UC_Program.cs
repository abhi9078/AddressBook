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
            return "Name is: " + First_Name + Last_Name + "\nAddress: " + Address + "\nCity is " + City +
                "\nState is " + State + "\nPostal code is: " + PostalCode + "\nPhone: " + PhoneNumber + "\nEmail is " + Email;
        }
    }

    internal class UC_Program
    {
        public List<Person> person = new List<Person>();

        public void Display()
        {
            Console.WriteLine("Welcome to Program");
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

        public UC_Program()
        {
            string json = File.ReadAllText(@"D:\.Net\Assignment\day10\AddressBookManagement\AddressBookManagement\result.json");
            if (json.Length > 0)
            {
                person = JsonConvert.DeserializeObject<List<Person>>(json);
            }
            else
                person = new List<Person>();
        }

    }


}
