namespace examenPROjuni
{
    public class Locatie
    {
        public string NaamLocatie { get; set; }
        public string Adres { get; set; }
        public int Capaciteit { get; set; }

        private List<Dier> _Dieren;

        public List<Dier> Dieren
        {
            get { return _Dieren; }
        }

        public void VerwijderDierVanLocatie(Dier objDier)
        {
           _Dieren.Remove(objDier);
        }

        public void VoegDierToeAanLocatie(Dier objDier)
        {
            _Dieren.Add(objDier);
        }

        public int AantalDierenOpLocatie()
        {
            return _Dieren.Count;
        }

        public int AantalPlaatsenVrij()
        {
            return Capaciteit - _Dieren.Count;
        }

        public int AantalMannelijkeDierenOpLocatie()
        {
            int count = 0; 

            foreach (Dier item in _Dieren)
            {
                if (item.getGeslachtVoluit().ToLower() == "mannelijk")
                {
                    count++;
                }
            }
            return count;
        }

        public int AantalVrouwelijkeDierenOpLocatie()
        {
            return _Dieren.Count-AantalMannelijkeDierenOpLocatie();
        }

        public Locatie()
        {
            _Dieren = new List<Dier>();
        }

        public Locatie(string naamLocatie, string adres, int capaciteit)
        {
            NaamLocatie = naamLocatie;
            Adres = adres;
            Capaciteit = capaciteit;

            _Dieren = new List<Dier>(); 
        }

        public override string ToString()
        {
            return NaamLocatie; 
        }
    }
}