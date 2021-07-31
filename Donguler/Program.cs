using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Temel Kurs";
            string kurs2 = "Python";
            string kurs3 = "Java";
            //array-dizi
            //yukarıdakiler gibi tek tek kurs tanımlayamayız, aşağıdaki hale getireceğiz.. array- dizi halinde liste tutacağız

            string[] kurslar = new string[] { "Temel Kurs", "Python","Java","Boş Kurs" }; //yukarıdaki kursları buralarda tutacağız toplu olarak

            // i=i+2 veya i+=2
            for (int i = 0; i < kurslar.Length ; i++) //i++ , i yi birer birer artırır
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("***foreach***");


            foreach (string kurs in kurslar)//buradaki kurs X veya Z de olabilir, alias'tır. TAKMA AD.
            {
                //dizi temelli yapıları foreach tek tek döner... for da kullanılabilir fark etmez
                Console.WriteLine(kurs); 
            }

            Console.WriteLine("************Sayfa Sonu*********");
        }
    }
}
