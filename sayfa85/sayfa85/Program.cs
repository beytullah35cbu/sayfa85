using System;
namespace or202
{
    class Program //sonu sıfır olan sayıları topla
    {
        public static void Main(string[] args)
        {
            int[] B = new int[5];


            int toplam =0;

            for (int a = 0; a <= B.Length - 1; a++)
            {
                Console.Write(a + ". Elemanı Gir: ");

                B[a] = Int32.Parse(Console.ReadLine());

                if (B[a] % 10 == 0)
                {
                    toplam += B[a];
                }
            }               //döngü for ile olsaydı a++ satırına gerek kalmayacaktı! //for yaptım *_*
            
            Console.WriteLine("Son Rakamı Sıfır Olan Sayıların toplamı: " + toplam);


            Console.ReadKey();
        }
    }
}