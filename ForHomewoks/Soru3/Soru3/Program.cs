namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Bir pozitif tam sayı girin: ");
        int input =int.Parse(Console.ReadLine());
        int result=default;
        for (int i = 1; i < input+1; i++)
        {
            if (input%i==0){
                System.Console.WriteLine(i);
            }
        }
    }
}
