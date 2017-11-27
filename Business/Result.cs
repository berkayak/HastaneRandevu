using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Result
    {
        public bool HataDurumu { get; set; }
        public string SonucMesajı { get; set; }

        public void HataYok()
        {
            HataDurumu = false;
            SonucMesajı = "Başarılı";
        }

        public void HataVar()
        {
            HataDurumu = true;
            SonucMesajı = "Hata Oluştu";
        }

        public void HataVar(string hataMesajı)
        {
            HataDurumu = true;
            SonucMesajı = hataMesajı;
        }
    }
}
