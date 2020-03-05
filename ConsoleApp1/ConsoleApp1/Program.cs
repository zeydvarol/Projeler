using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string readText = Console.ReadLine();
                string[] words = readText.Split(" ");
                var isNumeric1 = int.TryParse(words[0], out int first);
                var isNumeric2 = int.TryParse(words[2], out int secont);
                if (words.Length!=3)
                {
                    Console.WriteLine("uzunlukta sıkıntı var.");
                }
                else if (!isNumeric1)
                {
                    Console.WriteLine("ilk girilen sayi hatali");
                }
                else if (!isNumeric2)
                {
                    Console.WriteLine("ikinci girilen sayi hatali");
                }
             
                else
                {
                    String al = words[1];

                    switch (al)
                    {
                        case "+":
                            int toplam = first + secont;
                            Console.WriteLine(first + " " + "+" + " " + secont + "=" + toplam);
                            break;
                        case "-":
                            int cikar = first - secont;
                            Console.WriteLine(first + " " + "-" + " " + secont + "=" + cikar);
                            break;
                        case "*":
                            int carp = first * secont;
                            Console.WriteLine(first + " " + "*" + " " + secont + "=" + carp);
                            break;
                        case "/":
                            int bol = first / secont;
                            Console.WriteLine(first + " " + "/" + " " + secont + "=" + bol);
                            break;
                        default:
                            Console.WriteLine("Girilen karakter geçersiz.");
                            break;

                    }

                }




            }
        }
    }
}
