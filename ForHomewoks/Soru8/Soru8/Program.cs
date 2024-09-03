namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Pozitif bir tam sayı yazın: ");
        int input=int.Parse(Console.ReadLine());
        int sonuç=0;
        for (int i = input; i>=1; i--)
        {
            sonuç=i*i;
            System.Console.WriteLine($"{i}={sonuç}");
        }
    }
}
