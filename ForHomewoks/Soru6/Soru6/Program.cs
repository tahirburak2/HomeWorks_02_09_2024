namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("10'dan büyük bir sayı yazın: ");
        int input = int.Parse(Console.ReadLine());
        
        
        if (input>10){
            for (int i = 1; i <= input; i++)
            {
               int result = i*i;
                System.Console.WriteLine($"{i}^2={result}");
            }
        }else{
            System.Console.WriteLine("Lütfen 10dan büyük bir sayı giriniz!");
        }
    }
}
