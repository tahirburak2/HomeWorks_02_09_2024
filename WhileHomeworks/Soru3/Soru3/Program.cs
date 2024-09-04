namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir tam sayı yazınız (negatif sayı yazdığınızda program sonlarnır ve yazdığınz sayıların karesini gösterir.):");
        int input;
        int kare;
        do
        {
             input = int.Parse(Console.ReadLine());

            if (input>=0)
            {
                kare=input*input;
                System.Console.WriteLine($"{input}^2={kare}");
            }
        } while (input>=0);
        System.Console.WriteLine("Program sonlandı");
    }
}
