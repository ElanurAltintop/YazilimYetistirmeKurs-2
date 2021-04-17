using System;

namespace YazilimYetistirmeKurs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";

            //aray (dizi)
            string[] kurslar = new string[]  //Tipi artık string array oldu
            {
                "Yazılım geliştirici yetiştirme kampı", "Programlamaya başlangıç için temel kurs",
                "C# ve Java"
            };


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)  //Dizileri tek tek dolaşmaya yarar
            {
                Console.WriteLine(kurs);
            }  
        }
    }
}
