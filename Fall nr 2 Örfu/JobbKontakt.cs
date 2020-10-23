namespace Fall_nr_2_Örfu
{
    /// <summary>
    ///  Möjlighet till flera telefon nummer på en kontakt
    /// Möjlighet tillatt ändra en konntakt
    /// Lista alla kontakter
    /// Sök funktion på t.ex namn tele, adress.
    /// Idiotsäkra från felaktiga inmatningar.
    /// Feedback om fel görs - felmeddelande.
    /// </summary>

    class JobbKontakt : IKontakt
    {
        public string Namn { get; set; }
        public string Address { get; set; }
        public string Nummer { get; set; }
        public string Epost { get; set; }

        public JobbKontakt(string namn, string address, string nummer, string epost)
        {
            Namn = namn;
            Address = address;
            Nummer = nummer;
            Epost = epost;

        }
        public JobbKontakt()
        { }
    }
    class PrivatKontakt : IKontakt
    {
        public string Namn { get; set; }
        public string Address { get; set; }
        public string Nummer { get; set; }
        public string Epost { get; set; }

        public PrivatKontakt(string namn, string address, string nummer, string epost)
        {
            Namn = namn;
            Address = address;
            Nummer = nummer;
            Epost = epost;

        }
    }
}





