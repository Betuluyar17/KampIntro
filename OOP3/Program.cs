using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager= new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { databaseLoggerService, fileLoggerService, new SmsLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();

            // 1. yöntem
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);
            // 2. yöntem
            //basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> { databaseLoggerService, new SmsLoggerService() });
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers );

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, konutKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
} 
  