namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Pozitif bir tam sayı girin: ");
        int input = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < input + 1; i++)
        {
for (int a = 0; a < i; a++)
{
    System.Console.Write("*");
}
System.Console.WriteLine();
        }
    }
}
