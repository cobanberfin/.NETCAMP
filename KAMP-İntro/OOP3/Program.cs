using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NeedKreditManager needKreditManager = new NeedKreditManager();
            İnstallment_loan installment_Loan = new İnstallment_loan();
            ICreditManager houseCreditManager = new HouseCreditManager();
           // ICreditManager esnafkredı= new EsnafKredisi();

            ILoggerService databaseloggerservıce = new DatabaseLoggerService();
            ILoggerService fileloggerservice = new FileLoggerService();


            ApplyManager applyManager = new ApplyManager();
            applyManager.BasvuruYap(new EsnafKredisi(),databaseloggerservıce);

            List<ICreditManager> credits = new List<ICreditManager>() {needKreditManager,houseCreditManager };
            // applyManager.KrediOnBilgilendirmesiYap(credits);


            List<ILoggerService> loggers = new List<ILoggerService> { new FileLoggerService(), new DatabaseLoggerService() };

            Console.ReadLine();

        }
    }
}