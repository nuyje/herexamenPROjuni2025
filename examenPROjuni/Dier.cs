using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenPROjuni
{
    public class Dier
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public string Geslacht { get; set; }
        public int OrdeID { get; set; }


        public string getGeslachtVoluit()
        {
            if (Geslacht == "False")
            {
                return "Mannelijk"; 
            }
            else
            {
                return "Vrouwelijk";
            }
        }

        public Dier(int iD, string naam, string omschrijving, string geslacht, int ordeID)
        {
            ID = iD;
            Naam = naam;
            Omschrijving = omschrijving;
            Geslacht = geslacht;
            OrdeID = ordeID;
           
        }

        public override string ToString()
        {
            return Naam; 
        }
    }
}
