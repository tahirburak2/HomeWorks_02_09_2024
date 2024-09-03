namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        
        int input=1;
        int toplam=default;

        Console.WriteLine("Pozitif tam sayı giriniz(0'a bastığınızda program sona erer.): ");
        do
           {
            
            input = int.Parse(Console.ReadLine());
           
            toplam +=input;
            
        } while (input!=0);
            System.Console.WriteLine(toplam);
    
        
    }
}
