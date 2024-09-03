namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
       System.Console.Write("Bir sayı giriniz: ");
       int girilen=int.Parse(Console.ReadLine());
       int toplam =0;
       for (int i = 1; i < girilen+1; i++)
       {
        toplam=toplam+i;

       }
       System.Console.WriteLine($"{toplam}");
    }
}
