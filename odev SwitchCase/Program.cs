using System;

namespace asdasdasd
{
    class Program
    {
        static void Main(string[] args)
        {
            //if else yapısının doğrudan case ler ile yönlendirilmiş halidir.
            //hangi case ile eşleşme varsa oradaki bloğa girip çalışır

            int sayi = 4;
            switch (sayi)
            {
                case 1:
                    Console.WriteLine("BİR");
                    break;
                case 2:
                    Console.WriteLine("İKİ");
                    break;

                default: //default ELSE karşılık gelir
                    Console.WriteLine("HİÇBİRİ");
                    break;
            }
        }
    }
}
