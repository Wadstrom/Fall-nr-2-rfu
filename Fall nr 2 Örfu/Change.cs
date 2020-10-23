using System;
using System.Linq;

namespace Fall_nr_2_Örfu
{
    class Change
    {
        public void ChangeContact()
        {
            Program.jobbKontaktLista.AddRange(Program.privatKontaktLista);
            Console.WriteLine("1. erik 2. emil"); // visa numererade lista
            int a = Convert.ToInt32(Console.ReadLine());
            int b = (a - 1);
            Program.jobbKontaktLista.ElementAt(b);
            

        }
        public void EditContact()
        {
           // privatKontaktLista[someIndex].SomeProperty = someValue;
        }

    }
}
