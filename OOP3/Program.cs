﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            

            IKrediManager tasitKrediManager = new TasitKrediManager();
            

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService dbLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager ,tasitKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
