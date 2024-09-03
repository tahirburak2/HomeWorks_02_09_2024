namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("İki pozitif tam sayı girin: ");
        int input1=int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());
       int toplam=1;
        for (int i = input1; i <= input2; i++)
        {
            toplam*=i;
            
        }
        System.Console.WriteLine(toplam);
    }
}
