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
        Console.Write(" ");

        Console.ResetColor();
       
        for (int sitz = 1; sitz <= kinosaal.AnzahlSitze; sitz++)
        {
            Console.Write(sitz + " ");
        }

        Console.WriteLine();

        for (int reihe = 0; reihe < kinosaal.AnzahlReihen; reihe++)
        {
            Console.Write($"{reihe + 1:D2} ");

            for (int sitz = 0; sitz < kinosaal.AnzahlSitze; sitz++)
            {
                char status = kinosaal.Sitzplaetze[reihe, sitz];

                if (status == 'R')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                if (status == 'B')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write(status + " ");

                Console.ResetColor();
            }

            Console.WriteLine();
        }
    }
}