using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinosaal_Ticketverwaltung__CineCentral_.Models
{
    public class Kinosaal
    {
        public int AnzahlReihen { get; set; }
        public int AnzahlSitze {  get; set; }

        public char[,] Sitzplaetze { get; set; }

        public Kinosaal(int anzahlReihen, int anzahlSitze)
        {
        AnzahlReihen = anzahlReihen;
        AnzahlSitze = anzahlSitze;

            Sitzplaetze = new char[AnzahlReihen, AnzahlSitze];
            InitialisiereSaal();
        }
        private void InitialisiereSaal()
        {
           for (int reihe = 0; reihe < AnzahlReihen; reihe++)
            {
                for (int sitz = 0; sitz < AnzahlSitze; sitz++)
                {
                    Sitzplaetze[reihe, sitz] = 'F';
                }
            }
        }


    }
}
