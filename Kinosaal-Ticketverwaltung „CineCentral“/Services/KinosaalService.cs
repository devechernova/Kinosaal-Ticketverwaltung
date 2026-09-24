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
        kinosaal.Sitzplaetze[reiheIndex, sitzIndex] = 'B';
    }
   public void ReserviereSitz(Kinosaal kinosaal, int reihe, int sitz)
        {
        int reiheIndex = reihe - 1;
        int sitzIndex = sitz - 1;
        kinosaal.Sitzplaetze[reiheIndex, sitzIndex] = 'R';
    }
   public void GibSitzFrei(Kinosaal kinosaal, int reihe, int sitz)
        {
        int reiheIndex = reihe - 1;
        int sitzIndex = sitz - 1;
        kinosaal.Sitzplaetze[reiheIndex, sitzIndex] = 'F';
    }


}
