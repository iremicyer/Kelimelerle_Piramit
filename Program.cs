
using System;

namespace Kelimeler_ile_Piramit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mesajinizi giriniz:");
            string mesaj = Console.ReadLine();

            string goster = "";
            string piramit = "*";

            for (int i = 0; i < mesaj.Length; i++)
            {
                goster += mesaj[i];

                for (int j = 0; j < mesaj.Length; j++)
                {
                    if ((mesaj.Length - goster.Length) / 2 == j) // Döngü orta sayıya ulaştığında elimizdeki goster isimli kelimeyi ekliyoruz... 
                    {
                        piramit += goster; 
                        j += goster.Length; // kelime uzunluğumuz kadar 2. döngümüzün sayacını artrıyoruz ki fazlada yıldız eklemesin...
                    }
                    piramit += "*"; // Eğer kelime eklemiyorsak yıldız ekliyoruz... 
                }
                Console.WriteLine(piramit); // Ekranda gösteriyoruz... 
                piramit = "*"; // diğer saatır da yine piramiti sıfırlıyoruz ki bir önceki satır ile karışmasın... 

            }
            Console.ReadKey();
        }
    }
}
    

