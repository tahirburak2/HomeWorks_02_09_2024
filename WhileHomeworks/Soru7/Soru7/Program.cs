namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Pozitif bir tam sayı alın: ");
        int girilen=int.Parse(Console.ReadLine());
        System.Console.Write("Üst sınır giriniz: ");
        int ustSınır=int.Parse(Console.ReadLine());
       while (ustSınır>girilen)
       {
            Console.WriteLine("Sayı: " + girilen); 
            girilen *= 2;
        }
        System.Console.WriteLine("sayı üst sınıra ulaştı.");
    }
}
