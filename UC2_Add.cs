using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class UC2_Add
    {
		public class AddingContact
		{

			private String FirstName;
			private String LastName;
			private String Address;
			private int Zip;
			private String City;
			private String State;
			private int PhoneNumber;
			private String Email;

			public AddingContact(String FirstName, String LastName, String Address, String City, int Zip,
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

			public AddingContact()
			{

			}


			public void details()
			{
				
				Console.WriteLine("Enter your First Name");
				String FirstName = Convert.ToString(Console.ReadLine());
				Console.WriteLine("Enter your Last Name");
				String LastName = Convert.ToString(Console.ReadLine());
				Console.WriteLine("Enter your Address");
				String Address = Convert.ToString(Console.ReadLine());
				Console.WriteLine("Enter your Zip Code");
				int Zip = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter your City name");
				String City = Convert.ToString(Console.ReadLine());
				Console.WriteLine("Enter your State name");
				String State = Convert.ToString(Console.ReadLine());
				Console.WriteLine("Enter your Phone number");
				int PhoneNumber = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter your e-mail address");
				String Email = Convert.ToString(Console.ReadLine());
				Console.WriteLine("First Name: " + FirstName);
				Console.WriteLine("Last Name: " + LastName);
				Console.WriteLine("Address is : " + Address);
				Console.WriteLine("Zip code: " + Zip);
				Console.WriteLine("City Name: " + City);
				Console.WriteLine("State name: " + State);
				Console.WriteLine("Phone Number: " + PhoneNumber);
				Console.WriteLine("E-Mail: " + Email);
			}
			public static void Main(String[] args)
			{
				Console.WriteLine("Welcome to the Address Book");
				AddingContact contacts = new AddingContact();
				contacts.details();
			}
		}
	}
}
