// See https://aka.ms/new-console-template for more information
class Program1
{
    static void Main()
    {
        Console.WriteLine("Lütfen sayaç değeri giriniz: ");
        int sayac = Convert.ToInt32(Console.ReadLine());
        int a = 1;
        int b = 1;
        int c = 0;
        Console.Write("Fİbonacci dizisi: " + a + " " + b + " ");
        do
        {
            c = a + b;
            a = b;
            b = c;
            if (c<=sayac)
            {
                Console.Write(c + " ");
            }
        } while (c<=sayac);
       
        Console.ReadLine();

    }
}


