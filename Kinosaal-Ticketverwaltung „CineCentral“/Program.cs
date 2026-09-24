using Kinosaal_Ticketverwaltung__CineCentral_.Models;
using Kinosaal_Ticketverwaltung__CineCentral_.Services;

namespace Kinosaal_Ticketverwaltung__CineCentral_;

public class Program
{
    static void Main(string[] args)
    {
       Kinosaal kinosaal = new Kinosaal(10, 5);
       AnzeigeService anzeigeService = new AnzeigeService();

       anzeigeService.ZeigeKinosaal(kinosaal);
    }
}
