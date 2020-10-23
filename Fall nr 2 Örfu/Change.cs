using System;
using System.Collections.Generic;
using System.Linq;

namespace Fall_nr_2_Örfu
{
    public class Change
    {
        static public void ChangeContact()
        {
            int valMeny1 = 0;
            do
            {
                try
                {

                    Console.WriteLine("I vilken vill du ändra\n1. Privatkontakter.\n2. Jobbkontakter\n3. Tillbaka");
                    valMeny1 = Convert.ToInt32(Console.ReadLine());
                    switch (valMeny1)
                    {
                        case 1:

                            Console.Clear();
                            Lista_hantera.ÖppnarListan(Program.jobbKontaktLista);
                            ChangeList(Program.jobbKontaktLista);
                            break;
                        case 2:

                            Console.Clear();
                            Lista_hantera.ÖppnarListan(Program.privatKontaktLista);
                            ChangeList(Program.privatKontaktLista);
                            break;
                        case 3:
                            Console.Clear();
                            Lista_hantera.VisaLista();
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
            int valMeny1 = 0;
            int a;
            int b;
            string välj = "Välj kontakt du vill ändra med hjälp av siffran framför dennes namn. ";
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Vad vill du ändra?\n1. Namn | 2. Address | 3. Nummer | 4. Email ");
                    valMeny1 = Convert.ToInt32(Console.ReadLine());
                    switch (valMeny1)
                    {
                        case 1:
                            Lista_hantera.TextToColor(välj);
                            Lista_hantera.ÖppnarListan(KontaktLista);
                            a = Convert.ToInt32(Console.ReadLine());
                            b = (a - 1);
                            Console.WriteLine($"Skriv in det nya namnet för {KontaktLista.ElementAt(b).Namn}");
                            string newName = Console.ReadLine();
                            KontaktLista.ElementAt(b).Namn = newName;
                            Console.Clear();
                            Lista_hantera.VisaLista();
                            break;
                        case 2:
                            Lista_hantera.TextToColor(välj);
                            Lista_hantera.ÖppnarListan(KontaktLista);
                            a = Convert.ToInt32(Console.ReadLine());
                            b = (a - 1);
                            Console.WriteLine($"Skriv in en ny adress till {KontaktLista.ElementAt(b).Namn}");
                            string newAdress = Console.ReadLine();
                            KontaktLista.ElementAt(b).Address = newAdress;
                            Console.Clear();
                            Lista_hantera.VisaLista();
                            break;
                        case 3:
                            Lista_hantera.TextToColor(välj);
                            Lista_hantera.ÖppnarListan(KontaktLista);
                            a = Convert.ToInt32(Console.ReadLine());
                            b = (a - 1);
                            Console.WriteLine($"Skriv in ett nytt mobilnummer till {KontaktLista.ElementAt(b).Namn}");
                            string newNumber = Console.ReadLine();
                            KontaktLista.ElementAt(b).Nummer = newNumber;
                            Console.Clear();
                            Lista_hantera.VisaLista();
                            break;
                        case 4:
                            Lista_hantera.TextToColor(välj);
                            Lista_hantera.ÖppnarListan(KontaktLista);
                            a = Convert.ToInt32(Console.ReadLine());
                            b = (a - 1);
                            Console.WriteLine($"Skriv in ny email till {KontaktLista.ElementAt(b).Namn}");
                            string newEmail = Console.ReadLine();
                            KontaktLista.ElementAt(b).Epost = newEmail;
                            Console.Clear();
                            Lista_hantera.VisaLista();
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
                    valMeny1 = 5;
                }
            }
            while (valMeny1 >= 4);

        }






        //---EMIL-------------------------------------------------------------------------------------------------------------



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
