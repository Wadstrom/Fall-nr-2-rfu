using System;
using System.Collections.Generic;


namespace Fall_nr_2_Örfu
{
    class Lista_hantera
    {

        

//-SKAPAR OCH VISAR--------------------------------------------------------------------------------------
        static public void VisaLista()
        {
            //"GUI"
            string text = "| 1. Sök | 2. Lägg till kontakt | 3. Ändra kontakt | 4. Tillbaka |";
            TextToColor(text);

            //objekt
            

            //VISAR listan, metod "ÖppnarListan" kolla nedan
            string text2 = "Kontakter privat: ";
            TextToColor(text2);
            ÖppnarListan(Program.privatKontaktLista);


            string text3 = "\nKontakter jobb: ";
            TextToColor(text3);
            ÖppnarListan(Program.jobbKontaktLista);


            //Val som man kan göra, genom while loop och switch
            bool loopContinue = true;
            while (loopContinue == true)
            {

                Console.WriteLine(" ");
                string val = Console.ReadLine();

                switch (val)
                {
                   
                    case "1":
                        Console.WriteLine("Söker i lista");
                        Console.Clear();
                        Console.ReadLine();
                        loopContinue = false;
                        //Sök();
                        break;

                    case "2":
                        Console.WriteLine("Lägg till kontakt");
                        Console.Clear();
                        Meny2();
                        loopContinue = false;
                        break;

                    case "3":
                        Console.WriteLine("Ändra kontakt");
                        Console.Clear();
                        Console.ReadLine();
                        loopContinue = false;
                        break;

                    case "4":
                        Console.WriteLine("Går tillbaka till huvudmeny");
                        Console.Clear();
                        Program.Huvudmeny();
                        loopContinue = false;
                        break;

                    default:
                        Console.WriteLine("Okänt värde, tryck 1 ELLER 2");

                        loopContinue = true;
                        break;
                }
            }

        }

        //här är list-metoden
//--VISAR LISTAN OCH STRUKTURERAR--------------------------------------------------------------------
        private static void ÖppnarListan(List<IKontakt> KontaktLista)
        {

            foreach (var uppgift in KontaktLista)
            {
                //tar ut int längd från varje namn/adress/nummer
                //för att veta hur mycket mellanrum mellan varandra

                int namnLength = uppgift.Namn.Length;
                int addressLength = uppgift.Address.Length;
                int NummerLength = uppgift.Nummer.Length;
                int EpostLength = uppgift.Epost.Length;

                string namn = uppgift.Namn;
                string address = uppgift.Address;
                string nummer = uppgift.Nummer;
                string epost = uppgift.Epost;

                while (namnLength < 15)
                {
                    ++namnLength;
                    namn = namn + new string(" ");
                }

                while (addressLength < 32)
                {
                    ++addressLength;
                    address = address + new string(" ");
                }

                while (NummerLength < 12)
                {
                    ++NummerLength;
                    nummer = nummer + new string(" ");
                }

                while (EpostLength < 16)
                {
                    ++EpostLength;
                    epost = epost + new string(" ");
                }

                Console.WriteLine($"Namn: {namn} Address: {address} Nummer: {nummer} Epost: {epost}");
            }
        }
//-FÄRG METOD------------------------------------------------------------------------------------------
        public static void TextToColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
//--LÄGGER TILL------------------------------------------------------------------------------------------
        static public void AddContacts(List<IKontakt> lista)
        {
            string mataUtLista = string.Empty;
            JobbKontakt contactinfo = new JobbKontakt();

            do
            {
                try
                {
                    
                    Console.Write("Namn: ");
                    string name = Validator.ValidateName(Console.ReadLine());

                    Console.Write("Adress: ");
                    string adress = Validator.ValidateName(Console.ReadLine());

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("MobilNummer: ");
                    string phoneNumber = Validator.ValidateNumber(Console.ReadLine());

                    JobbKontakt test = new JobbKontakt(name, adress, phoneNumber, email);
                    lista.Add(test);

                    Console.WriteLine("\nVill du lägga till en till kontakt klicka enter");
                    Console.WriteLine("Annars matar du in X");

                    mataUtLista = Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            while (mataUtLista != "X" && mataUtLista != "x");
            Console.Clear();

            VisaLista();

        }
//--MENY2------------------------------------------------------------------------------------------------
       static public void Meny2()
        {
            int valMeny1 = 0;
            do
            {
                try
                {

                    Console.WriteLine("Vill du lägga till\n1. Jobbkontakt.\n2. Privatkontakt\n3. Tillbaka");
                    valMeny1 = Convert.ToInt32(Console.ReadLine());
                    switch (valMeny1)
                    {
                        case 1:
                            Console.WriteLine("JOBBKONTAKT");
                            Console.Clear();
                            AddContacts(Program.jobbKontaktLista);
                            break;
                        case 2:
                            Console.WriteLine("PKONTAKT");
                            Console.Clear();
                            AddContacts(Program.privatKontaktLista);
                            break;                                  
                        case 3:
                            Console.WriteLine("Tillbaka");
                            Console.Clear();
                            VisaLista();
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
    }
}


