using System;

public class Program
{
    public static void Main()
    {
        int[] nizNeparnih = new int[10];
        int[] nizParnih = new int[10];
        int brojacNeparnih = 0;
        int brojacParnih = 0;

        while (true)
        {
            Console.Write("Unesite broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj == 0 || brojacNeparnih + brojacParnih >= 10)
                break;

            if (broj % 2 == 0)
            {
                nizParnih[brojacParnih] = broj;
                brojacParnih++;
            }
            else
            {
                nizNeparnih[brojacNeparnih] = broj;
                brojacNeparnih++;
            }
        }

        Console.WriteLine("Niz neparnih brojeva:");
        for (int i = 0; i < brojacNeparnih; i++)
        {
            Console.WriteLine(nizNeparnih[i]);
        }

        Console.WriteLine("Niz parnih brojeva:");
        for (int i = 0; i < brojacParnih; i++)
        {
            Console.WriteLine(nizParnih[i]);
        }
    }
}