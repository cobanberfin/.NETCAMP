using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplyManager
    {//method ınjectıon
        public void BasvuruYap(ICreditManager creditManager,ILoggerService loggerService)
        {
            //basvuru bılglerı degerlendırme

            creditManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager>credits)
        {

            foreach (var item in credits)
            {
                item.Hesapla();
            }

        }
    }
}
