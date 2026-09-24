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

        anzeigeService.ZeigeKinosaal(kinosaal);
       
        Console.WriteLine();
        Console.WriteLine("Aktion wählen:");
        Console.WriteLine("b = belegen");
        Console.WriteLine("r = reservieren");
        Console.WriteLine("f = freigeben");

        string aktion = Console.ReadLine();

        Console.Write("Reihe: ");
        int reihe = Convert.ToInt32(Console.ReadLine());

        Console.Write("Sitz: ");
        int sitz = Convert.ToInt32(Console.ReadLine());

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

        anzeigeService.ZeigeKinosaal(kinosaal);
        Console.WriteLine();
        Console.WriteLine("Beliebige Taste drücken...");
        Console.ReadKey();
    }
}
