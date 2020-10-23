using System;
using System.Linq;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Fall_nr_2_Örfu
{
    public class Change
    {
      static  public void ChangeContact()
        {
            int valMeny1 = 0;
            do
            {
                try
                {

                    Console.WriteLine("I vilken vill du ändra\n1. Jobbkontakt.\n2. Privatkontakt\n3. Tillbaka");
                    valMeny1 = Convert.ToInt32(Console.ReadLine());
                    switch (valMeny1)
                    {
                        case 1:
                            Console.WriteLine("JOBBKONTAKT");
                            Console.Clear();
                            Lista_hantera.ÖppnarListan(Program.jobbKontaktLista);
                            ChangeList(Program.jobbKontaktLista);
                            break;
                        case 2:
                            Console.WriteLine("PKONTAKT");
                            Console.Clear();
                            Lista_hantera.ÖppnarListan(Program.privatKontaktLista);
                            ChangeList(Program.privatKontaktLista);
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Du måste välja ett motsvarande menyval med siffer tangenterna");

                            break;
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message + "Tryck på valfri tanget");
                    Console.ReadKey();
                    Console.Clear();
                    valMeny1 = 3;
                }
            }
            while (valMeny1 >= 4);
            

          

        }
        internal static void ChangeList(List<IKontakt> KontaktLista)
        {
            Console.WriteLine("Vilken kontakt vill du ändra?");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = (a - 1);
            string number = Console.ReadLine();
              KontaktLista.ElementAt(b).Nummer = number;
            Lista_hantera.VisaLista();
        }










        static public void EditContact()
        {
            Console.WriteLine("Vill du ändra en privat eller en jobb-kontakt?");
            Console.WriteLine("1. Privat | 2. Jobb");

            string val1 = Console.ReadLine();

            bool loopContinue = true;
            while (loopContinue == true)
                switch (val1)
                {

                    case "1":

                        VäljPrivatLista();
                        loopContinue = false;

                        break;

                    case "2":
                        VäljJobbLista();
                        loopContinue = false;
                        break;

                    default:

                        break;
                }
        }



        static void VäljPrivatLista()
        {
            Console.WriteLine("Välj kontaktens ordningsnummer i listan du ska ändra");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = (a - 1);
            Console.WriteLine("Vill du ändra namn, address, nummer eller email?");
            Console.WriteLine("1. Namn | 2. Address | 3. Nummer | 4. Email ");

            string val2 = Console.ReadLine();
            bool loopContinue2 = true;
            while (loopContinue2 == true)
                switch (val2)
                {

                    case "1":
                        Console.WriteLine("Skriv in namn: ");
                        string newName = Console.ReadLine();
                        Program.privatKontaktLista[b].Namn = newName;
                        loopContinue2 = false;

                        break;

                    case "2":
                        Console.WriteLine("Skriv in addess: ");
                        string newAddress = Console.ReadLine();
                        Program.privatKontaktLista[b].Address = newAddress;
                        Lista_hantera.VisaLista();
                        loopContinue2 = false;
                        break;

                    case "3":
                        Console.WriteLine("Skriv in nummer: ");
                        string newNummer = Console.ReadLine();
                        Program.privatKontaktLista[b].Nummer = newNummer;
                        Lista_hantera.VisaLista();
                        loopContinue2 = false;
                        break;

                    case "4":
                        Console.WriteLine("Skriv in email: ");
                        string newEmail = Console.ReadLine();
                        Program.privatKontaktLista[b].Epost = newEmail;
                        Lista_hantera.VisaLista();
                        loopContinue2 = false;
                        break;

                    default:

                        break;
                }
        }
        static void VäljJobbLista()
        {
            Console.WriteLine("Välj kontaktens ordningsnummer i listan du ska ändra");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = (a - 1);
            Console.WriteLine("Vill du ändra namn, address, nummer eller email?");
            Console.WriteLine("1. Namn | 2. Address | 3. Nummer | 4. Email ");

            string val2 = Console.ReadLine();
            bool loopContinue2 = true;
            while (loopContinue2 == true)
                switch (val2)
                {

                    case "1":
                        Console.WriteLine("Skriv in namn: ");
                        string newName = Console.ReadLine();
                        Program.jobbKontaktLista[b].Namn = newName;
                        Lista_hantera.VisaLista();
                        loopContinue2 = false;

                        break;

                    case "2":
                        Console.WriteLine("Skriv in addess: ");
                        string newAddress = Console.ReadLine();
                        Program.jobbKontaktLista[b].Address = newAddress;
                        Lista_hantera.VisaLista();
                        loopContinue2 = false;
                        break;

                    case "3":
                        Console.WriteLine("Skriv in nummer: ");
                        string newNummer = Console.ReadLine();
                        Program.jobbKontaktLista[b].Nummer = newNummer;
                        Lista_hantera.VisaLista();
                        loopContinue2 = false;
                        break;

                    case "4":
                        Console.WriteLine("Skriv in email: ");
                        string newEmail = Console.ReadLine();
                        Program.jobbKontaktLista[b].Epost = newEmail;
                        Lista_hantera.VisaLista();
                        loopContinue2 = false;
                        break;

                    default:

                        break;
                }


        }

    }
}
