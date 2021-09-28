using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class UC1_create
    {
        public class CreateTheList
        {
            private String FirstName;
            private String LastName;
            private String Address;
            private int Zip;
            private String City;
            private String State;
            private int PhoneNumber;
            private String Email;

            public CreateTheList(String FirstName, String LastName, String Address, String City, int Zip,
                                   String State, int PhoneNumber, String Email)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Address = Address;
                this.Zip = Zip;
                this.City = City;
                this.State = State;
                this.PhoneNumber = PhoneNumber;
                this.Email = Email;
            }


            public void details()
            {
                Console.WriteLine("Firstname : " + FirstName);
                Console.WriteLine("Lastname : " + LastName);
                Console.WriteLine("Address : " + Address);
                Console.WriteLine("City : " + City);
                Console.WriteLine("State : " + State);
                Console.WriteLine("Zip : " + Zip);
                Console.WriteLine("PhoneNumber : " + PhoneNumber);
                Console.WriteLine("Email : " + Email);
            }
            public static void Main(String[] args)
            {
                Console.WriteLine("Welcome to the Address Book");
                CreateTheList contacts = new CreateTheList("Subhasish", "Sahu", "kol",
                        "Bhubaneswar", 123456, "odisha", 1234567890, "abc@gmail.com");
                contacts.details();
            }
        }
    }
}
