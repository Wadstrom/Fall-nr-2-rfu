using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Fall_nr_2_Örfu
{
    static class Search<T> where T : IKontakt // "type" som ersätter T generic parameters måste implementera IKontakt
    {
        static public List<T> Contacts { get; set; }

        // specific searching hejsan!
        static public List<T> SearchByName(string name)
        {

            return Contacts.FindAll(contact => contact.Namn == name);
        }


        static public List<T> SearchByAddress(string address)
        {

            return Contacts.FindAll(contact => contact.Address == address);
        }

        static public List<T> SearchByEmail(string email)
        {

            return Contacts.FindAll(contact => contact.Epost == email);
        }

        static public List<T> SearchByNumber(string number)
        {

            return Contacts.FindAll(contact => contact.Nummer == number);
        }


        // display
        static public List<T> DisplayForUser()
        {
            string[] options = new string[] { "Name", "Address", "Email" , "PhonNumber"};
            DisplayMeny(options);
            int choice = ChoosedOptionFromUser(options);

            switch (choice)
            {
                case 1:
                    string name = GetInput("Name", false, false).ToLower();
                    return SearchByName(name);
                case 2:
                    string address = GetAddressInput("Address", false, true).ToLower();
                    return SearchByAddress(address);
                case 3:
                    string email = GetInput("Email", true, true); // make it so that it only allows '_', '-', '@' and '.'
                    return SearchByEmail(email);
                default:
                    throw new Exception("Error from DisplayForUser!!");
            }
        }

        static private void DisplayMeny(string[] options)
        {
            Console.WriteLine("What you want to search by?");
            Console.WriteLine("--------------------------");


            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"({i + 1}) {options[i]}");
            }
        }

        static private int ChoosedOptionFromUser(string[] options)
        {
            int choice = 0;
            bool condition;

            do
            {
                Console.Write($"choose an option ({1}-{options.Length}): ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    choice = 0;
                }

                condition = choice < 1 || choice > options.Length;
                if (condition)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Invalid Option, try again!");
                    Console.ResetColor();
                }
            } while (condition);
            return choice;
        }

        // Form
        static private string GetInput(string msg, bool charAllowed = false, bool numberAllowed = false)
        {
            string text = "";
            bool condition;

            do
            {
                Console.Write($"Enter a {msg}: ");
                text = Console.ReadLine();

                if (!charAllowed && !numberAllowed)
                    condition = text == string.Empty || !text.All(char.IsLetter);
                else if (charAllowed && !numberAllowed)
                    condition = text == string.Empty || text.All(char.IsDigit);
                else if (!charAllowed && numberAllowed)
                    condition = text == string.Empty || !text.All(char.IsLetterOrDigit);
                else
                    condition = text == string.Empty;

                if (condition)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Invalid {msg} input");
                    Console.ResetColor();
                }
            } while (condition);
            return text;
        }


        static private string GetAddressInput(string msg, bool charAllowed = false, bool numberAllowed = false)
        {
            string text = "";
            bool condition;

            do
            {
                Console.Write($"Enter a {msg}: ");
                text = Console.ReadLine();

                if (!charAllowed && !numberAllowed)
                    condition = text == string.Empty || !text.All(char.IsLetter);
                else if (charAllowed && !numberAllowed)
                    condition = text == string.Empty || text.All(char.IsDigit);
                else if (!charAllowed && numberAllowed)
                    condition = text == string.Empty || !String.Concat(text.Where(c => !Char.IsWhiteSpace(c))).All(char.IsLetterOrDigit);
                else
                    condition = text == string.Empty;

                if (condition)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Invalid {msg} input");
                    Console.ResetColor();
                }
            } while (condition);
            return text;
        }

    }
}