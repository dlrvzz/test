using System.ComponentModel.Design;

namespace odev_2.Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rastgele kaç sayı verilsin?");
            Byte baslangic = byte.Parse(Console.ReadLine());
            Console.WriteLine("Sayi Araliginin Min Degeri");
            Byte minimum = byte.Parse(Console.ReadLine());
            Console.WriteLine("Sayi Araliginin Max Degeri");
            Byte maksimum = byte.Parse(Console.ReadLine());
            int[] sayilar = new int[baslangic];
            Random rnd = new Random();
            int tutulan;
            for (int i = 1; i < sayilar.Length; i++)
            {
                tutulan = rnd.Next(minimum, maksimum);
                for (int j = 0; j < i; j++)
                {
                    if (sayilar[j] == tutulan)
                    {
                        i--;
                        break;

                    }
                    else
                    {
                        sayilar[i] = tutulan;
                    }
                }

            }
            Array.Sort(sayilar);
            for (int i = 1; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        }
    }
}