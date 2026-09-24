using Kinosaal_Ticketverwaltung__CineCentral_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinosaal_Ticketverwaltung__CineCentral_.Services;

public class KinosaalService
{
    public void BelegeSitz(Kinosaal kinosaal, int reihe, int sitz)
    {
        int reiheIndex = reihe - 1;
        int sitzIndex = sitz - 1;

        char aktuellerStatus = kinosaal.Sitzplaetze[reiheIndex, sitzIndex];

        // Laut UML sind nur die Übergänge F -> B und R -> B erlaubt.
        // Wenn der Sitz frei ist oder zuvor von derselben Kasse reserviert wurde.
        if (aktuellerStatus == 'F' || aktuellerStatus == 'R')
        {
            kinosaal.Sitzplaetze[reiheIndex, sitzIndex] = 'B';
        }
        else if (aktuellerStatus == 'B')
        {
            Console.WriteLine("Verkauf nicht möglich. Der Sitz ist bereits verkauft.");
            Console.ReadLine();
        }
    }

    public void ReserviereSitz(Kinosaal kinosaal, int reihe, int sitz)
    {
        int reiheIndex = reihe - 1;
        int sitzIndex = sitz - 1;

        char aktuellerStatus = kinosaal.Sitzplaetze[reiheIndex, sitzIndex];

        // Laut UML ist nur der Übergang F -> R erlaubt.
        if (aktuellerStatus == 'F')
        {
            kinosaal.Sitzplaetze[reiheIndex, sitzIndex] = 'R';
        }
        else if (aktuellerStatus == 'R')
        {
            Console.WriteLine("Reservierung nicht möglich. Der Sitz ist bereits reserviert.");
            Console.ReadLine();
        }
        else if (aktuellerStatus == 'B')
        {
            Console.WriteLine("Reservierung nicht möglich. Der Sitz ist bereits verkauft.");
            Console.ReadLine();
        }
    }

    public void GibSitzFrei(Kinosaal kinosaal, int reihe, int sitz)
    {
        int reiheIndex = reihe - 1;
        int sitzIndex = sitz - 1;

        char aktuellerStatus = kinosaal.Sitzplaetze[reiheIndex, sitzIndex];

        // Laut UML sind die Übergänge R -> F und B -> F erlaubt.
        if (aktuellerStatus == 'R' || aktuellerStatus == 'B')
        {
            kinosaal.Sitzplaetze[reiheIndex, sitzIndex] = 'F';
        }
        else if (aktuellerStatus == 'F')
        {
            Console.WriteLine("Freigabe nicht möglich. Der Sitz ist bereits frei.");
            Console.ReadLine();
        }
    }
}


