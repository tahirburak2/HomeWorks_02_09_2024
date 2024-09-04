namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("İki pozitif sayı yazınız: ");
        int sayi1=int.Parse(Console.ReadLine());
        int sayi2=int.Parse(Console.ReadLine());
        int sonuc=1;
        do
        {
            if (sayi1<=sayi2)
            {
                sonuc *=sayi1;
                sayi1++;
            }
        } while (sayi1<=sayi2);
        System.Console.WriteLine(sonuc);
    }
}
