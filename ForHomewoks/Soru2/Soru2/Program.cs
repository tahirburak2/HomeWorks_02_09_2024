namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Bir sayı giriniz: ");
        int input = int.Parse(Console.ReadLine());
        int toplam =1;
        for (int i = 1; i < input+1; i++)
        {
            toplam =i*i;
            System.Console.WriteLine($"{toplam}//{i}^{i}");
            
        }
    }
}
