using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class UC3_edit
    {
		public class EditingContact
		{
			private String FirstName;
			private String LastName;
			private String Address;
			private int Zip;
			private String City;
			private String State;
			private int PhoneNumber;
			private String Email;

			public EditingContact(String FirstName, String LastName, String Address, String City, int Zip,
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

			public EditingContact()
			{

			}
			public String[] details()
			{
				
				String[] contact = new String[8];
				Console.WriteLine("Enter your First Name");
				String Firstname = Convert.ToString(Console.ReadLine());
				contact[0] = Firstname;
				Console.WriteLine("Enter your Last Name");
				String LastName = Convert.ToString(Console.ReadLine());
				contact[1] = LastName;
				Console.WriteLine("Enter your Address");
				String Address = Convert.ToString(Console.ReadLine());
				contact[2] = Address;
				Console.WriteLine("Enter your Zip code");
				String Zip = Convert.ToString(Console.ReadLine());
				contact[3] = Zip;
				Console.WriteLine("Enter your City name");
				String City = Convert.ToString(Console.ReadLine());
				contact[4] = City;
				Console.WriteLine("Enter your State name");
				String State = Convert.ToString(Console.ReadLine());
				contact[5] = State;
				Console.WriteLine("Enter your Phone number");
				String PhoneNumber = Convert.ToString(Console.ReadLine());
				contact[6] = PhoneNumber;
				Console.WriteLine("Enter your e-mail address");
				String Email = Convert.ToString(Console.ReadLine());
				contact[7] = Email;
				return contact;
			}
			public void edit(String[] contact)
			{
				Console.WriteLine("If you want to edit then press 1 else press 0");
				
				int read = Convert.ToInt32(Console.ReadLine());
				if (read == 1)
				{
					Console.WriteLine("Press the respective number you want to edit\n1  First Name\n2 Last Name\n3 Address\n4 Zip code\n5 City\n6 state\n7 phone number\n8 email");
					int input = Convert.ToInt32(Console.ReadLine());
					switch (input)
					{
						case 1:
							Console.WriteLine("Enter your new First Name");
							String newFirstName = Convert.ToString(Console.ReadLine());
							contact[0] = newFirstName;
							break;
						case 2:
							Console.WriteLine("Enter your new Last Name");
							String newLastName = Convert.ToString(Console.ReadLine());
							contact[1] = newLastName;
							break;
						case 3:
							Console.WriteLine("Enter your new Address");
							String newAddress = Convert.ToString(Console.ReadLine());
							contact[2] = newAddress;
							break;
						case 4:
							Console.WriteLine("Enter your new Zip code");
							String newZip = Convert.ToString(Console.ReadLine());
							contact[3] = newZip;
							break;
						case 5:
							Console.WriteLine("Enter your new city name");
							String newCity = Convert.ToString(Console.ReadLine());
							contact[4] = newCity;
							break;
						case 6:
							Console.WriteLine("Enter your new State name");
							String newState = Convert.ToString(Console.ReadLine());
							contact[5] = newState;
							break;
						case 7:
							Console.WriteLine("Enter your new Phone number");
							String newPhoneNumber = Convert.ToString(Console.ReadLine());
							contact[6] = newPhoneNumber;
							break;
						case 8:
							Console.WriteLine("Enter your new email");
							String newEmail = Convert.ToString(Console.ReadLine());
							contact[7] = newEmail;
							break;
						default:
							Console.WriteLine("Invalid Input");
							break;
					}
					Console.WriteLine("Your new details are as follows");
					for (int j = 0; j < contact.Length; j++)
					{
						Console.WriteLine(contact[j]);
					}
				}
				else if (read == 0)
				{
					for (int j = 0; j < contact.Length; j++)
					{
						Console.WriteLine(contact[j]);
					}

				}
				else
					Console.WriteLine("Invalid Input");
			}
			public static void Main(String[] args)
			{
				Console.WriteLine("Welcome to the Address Book");
				EditingContact contacts = new EditingContact();
				String[] info = contacts.details();
				contacts.edit(info);
			}
		}
	}
}
