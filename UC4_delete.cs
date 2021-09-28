using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class UC4_delete
    {
		public class DeletingContact
		{
			
			static String[] info;

			public static String[] Person()
			{
				String[] contact = new String[8];
				Console.WriteLine("Enter your details accordingly \n1. First Name\n2. Last Name\n"
						+ "3. Address \n4. Zipcode \n5. City \n6. State\n" + "7. Phone number\n 8. e-mail");
				for (int index = 0; index < contact.Length; index++)
					contact[index] = Convert.ToString(Console.ReadLine());
				return contact;
			}

			public static String[] edit(String[] contact)
			{
				Console.WriteLine(
						"Press the respective number you want to edit\n1  First Name\n2 Last Name\n3 Address\n4 Zip code\n5 City\n6 State\n7 phone number\n8 email");
				int choose = Convert.ToInt32(Console.ReadLine());
				if (choose >= 1 && choose <= 8)
				{
					choose--;
					Console.WriteLine("Enter the new details you choose to edit");
					contact[choose] = Convert.ToString(Console.ReadLine());
				}
				return contact;
			}

			public static String[] delete(String[] contact)
			{
				Console.WriteLine("Enter the first name of the contact you want to delete");
				String person_name = Convert.ToString(Console.ReadLine());
				if (contact[0].Equals(person_name))
				{
					for (int index = 0; index < contact.Length; index++)
						contact[index] = null;
					Console.WriteLine("Your contact has been deleted");
				}
				else
				{
					Console.WriteLine("Contact name not available");
				}
				return contact;
			}

			public static void option()
			{
				bool b1= true;
				while (b1)
				{
					Console.WriteLine("Type the following numbers if you want to perform the corresponding action");
					Console.WriteLine("1. EDIT\n2. DELETE\nAnyNumber. EXIT");
					int action = Convert.ToInt32(Console.ReadLine());
					switch (action)
					{
						case 1:
							info = edit(info);
							break;
						case 2:
							info = delete(info);
							break;
						default:
							b1 = false;
							break;
					}
					for (int index = 0; index < info.Length; index++)
					{
						Console.WriteLine(info[index]);
					}
				}
			}

			public static void Main(String[] args)
			{
				Console.WriteLine("WELCOME to the Address Book");
				info = Person();
				option();
				
			}
		}


	}
}
