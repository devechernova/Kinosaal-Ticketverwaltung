using Kinosaal_Ticketverwaltung__CineCentral_.Models;
using Kinosaal_Ticketverwaltung__CineCentral_.Services;

namespace Kinosaal_Ticketverwaltung__CineCentral_;

public class Program
{
    static void Main(string[] args)
    {
        Kinosaal kinosaal = new Kinosaal(10, 5);
        AnzeigeService anzeigeService = new AnzeigeService();
        KinosaalService kinosaalService = new KinosaalService();

        string aktion = "";

        while (aktion != "q")
        {
            //Console.Clear();

            anzeigeService.ZeigeKinosaal(kinosaal);

            Console.WriteLine();
            Console.WriteLine("Aktion wählen:");
            Console.WriteLine("b = belegen");
            Console.WriteLine("r = reservieren");
            Console.WriteLine("f = freigeben");
            Console.WriteLine("q = beenden");

            aktion = Console.ReadLine();

            Console.WriteLine("Eingegeben:");
            Console.WriteLine(aktion);

            if (aktion != "b" &&
                aktion != "r" &&
                aktion != "f" &&
                aktion != "q")
            {
                Console.WriteLine("Ungültige Aktion.");
                continue;
            }

            if (aktion == "q")
            {
                break;
            }

            int reihe;

            while (true)
            {
                Console.Write("Reihe: ");

                if (int.TryParse(Console.ReadLine(), out reihe)
                   && reihe >= 1
                   && reihe <= kinosaal.AnzahlReihen)
                {
                    break;
                }

                Console.WriteLine($"Ungültige Eingabe. Bitte eine Zahl zwischen 1 und {kinosaal.AnzahlReihen} eingeben.");
            }

            int sitz;

            while (true)
            {
                Console.Write("Sitz: ");

                if (int.TryParse(Console.ReadLine(), out sitz)
                    && sitz >= 1
                    && sitz <= kinosaal.AnzahlSitze)
                {
                    break;
                }

                Console.WriteLine($"Ungültige Eingabe. Bitte eine Zahl zwischen 1 und {kinosaal.AnzahlSitze} eingeben.");
            }

            if (aktion == "b")
            {
                kinosaalService.BelegeSitz(kinosaal, reihe, sitz);
            }

            if (aktion == "r")
            {
                kinosaalService.ReserviereSitz(kinosaal, reihe, sitz);
            }

            if (aktion == "f")
            {
                kinosaalService.GibSitzFrei(kinosaal, reihe, sitz);
            }
        }
    }
}