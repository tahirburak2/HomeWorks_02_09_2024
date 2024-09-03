namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Pozitif bir tam sayı giriniz: ");
        int input = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (input <= 1)
        {
            System.Console.WriteLine("Asal değildir.");
        }
        else
        {
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        System.Console.WriteLine(isPrime ? "Asal" : "Asal değil");
    }
}

