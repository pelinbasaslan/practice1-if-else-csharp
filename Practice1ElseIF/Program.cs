using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz.");
        //Console.ReadLine() string olduğu için int çevir numarayı. Sayısal değer lazım.
        int num = Convert.ToInt32(Console.ReadLine());
        if (num == 10)
        {
            Console.WriteLine($"Girilen sayı ({num}) 10'a eşittir.");
        }
        else if (num > 10)
        {
            Console.WriteLine($"Girilen sayı ({num}) 10'dan büyüktür.");
        }
        else
        {
            Console.WriteLine($"Girilen sayı ({num}) 10'dan küçüktür.");
        }
        if (num % 2 == 0)
        {
            Console.WriteLine("Girilen sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Girilen sayı tektir.");
        }
    }
}
