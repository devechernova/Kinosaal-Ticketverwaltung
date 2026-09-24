using Kinosaal_Ticketverwaltung__CineCentral_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinosaal_Ticketverwaltung__CineCentral_.Services;

public class AnzeigeService
{
    public void ZeigeKinosaal(Kinosaal kinosaal)
    {
        for (int reihe = 0; reihe < kinosaal.AnzahlReihen; reihe++)
        {
            for (int sitz = 0; sitz < kinosaal.AnzahlSitze; sitz++)
            {
                Console.Write(kinosaal.Sitzplaetze[reihe, sitz]+ " ");
            }

            Console.WriteLine();
        }
    }
}
