namespace programlama_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı sıralamak istiyorsunuz?");
            byte count = byte.Parse(Console.ReadLine());

            int[] numbers = new int[count];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                int randomNumber;
                do
                {
                    randomNumber = rnd.Next(100);

                    int j;
                    for (j = 0; j < i; j++)
                    {
                        if (numbers[j] == randomNumber)
                        {
                            break;
                        }
                    }

                    if (j == i)
                    {
                        numbers[i] = randomNumber;
                    }
                } while (numbers[i] == 0);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}