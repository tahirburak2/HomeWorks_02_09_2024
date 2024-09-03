namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Pozitif bir tam sayı giriniz: ");
        int input=int.Parse(Console.ReadLine());
        int toplam=0;
        for (int i = 1; i <= input; i++)
        {
            if (i%2==0){
                toplam +=i;
                
            }
        }
        System.Console.WriteLine(toplam);
    }
}
