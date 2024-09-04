namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pozitif tam sayılar girin(100den büyük bir sayı girerseniz program sonlanır):");
        int girilen;
        int tane=0;
        int toplam=0;
        int ortalama=0;
        do
        {
            girilen=int.Parse(Console.ReadLine());
            if (girilen<100){
                toplam+=girilen;
                tane++;
            }
        }while(girilen<100);
        System.Console.WriteLine($"Şuana kadar giridiniz sayıların toplamı:{toplam}");
System.Console.WriteLine($"Şuana kadar {tane} kadar sayı girdiniz.");
ortalama=toplam/tane;
System.Console.WriteLine($"Girdiğiniz sayıların ortalaması:{ortalama}");
    }
}
