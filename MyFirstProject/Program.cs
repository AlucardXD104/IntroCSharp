using System.Security.Cryptography.X509Certificates;

class Program
{
    static int age = 30;
    static int Age = 50;
    
    public static void Main(string[] args)
    {
        // Console.WriteLine ("Hello, world");
        // Console.WriteLine("age: " + age);
        // Console.WriteLine("Age: " + Age);
        // int num1 = 10;
        // float num2 = num1; 
        // Console.WriteLine($"num1 {num2} --- num2 {num2}");
        // float num3 = 12.45677f;
        // int num4 = (int)num3;
        // Console.WriteLine($"num3 {num3} --- num4 {num4}");

        // ReadLineExamples();
        // VariableOperationsExamples();
        // Compiti1();
        // Esercizio2();
        // Esercizio3();
        // Esercizio4();
        // SCExemples();
        // EsercizioIFELSE1pag38();
        // EsercizioIFELSE2pag38();
        EsercizioIFELSE3pag39();
    }
    public static void ReadLineExamples()
    {
        // Console.Write($"Dì il tuo nome e congniome: ");
        // string? name = Console.ReadLine();

        // Console.WriteLine($"Il Tuo Nome è {name}");

        // Console.Write("inserisci n1");
        // string? n1 = Console.ReadLine();

        // Console.Write("inserisci n2");
        // string? n2 = Console.ReadLine();

        // Console.Write("inserisci n2");
        // string? n3 = Console.ReadLine();

        // int number1 = int.Parse(n1);
        // int number2 = int.Parse(n2);
        // int number3 = int.Parse(n3);

        // Console.WriteLine($"Somma number1 + number2 - number3 = {number1 + number2 - number3}");
    }
    public static void VariableOperationsExamples()
    {
    //    Console.WriteLine($"Inserici 2 numeri");
    //    int a = int.Parse(Console.ReadLine());
    //    int b = int.Parse(Console.ReadLine());

    //    Console.WriteLine($"\n---- Operazione Aritemetica\n");
    //    int sum = a + b;
    //    Console.WriteLine($"Somma di A + B = {sum}");
    //    int diff = a - b;
    //    Console.WriteLine($"Sottrazione di A - B = {diff}");
    //    double div = a / b;
    //    Console.WriteLine($"Divisione di A / B = {div}");
    //    int prod = a * a;
    //    Console.WriteLine($"Prodotto di A * B = {prod}");
    //    int resto = a % b;
    //    Console.WriteLine($"Resto di A e B = {resto}");

    } 
    public static void Compiti1 ()
{
    // SBAGLIATO/NON FINITO
        Console.WriteLine($"\n---- OperazioneAritmetica");
        int a = 20;
        int b = 30;
        int sum = a + b;
        Console.WriteLine($"prodotto di a + b = {sum}");
}  
    public static void Esercizio2()
    {
        double discount = 20;
        double price = 100;
        double discountedPrice = price - (price * discount / 100);
        //prezzo - (prezzo * disocunt / 100)
        Console.WriteLine($" totale prodotto scontato = {discountedPrice}");
    
    }
    public static void Esercizio3()
    {
        float a = 10.567f;
        bool isPositive = a >= 0;
        Console.WriteLine($"{a} è Positivo? {isPositive}");
    }
    public static void Esercizio4 ()
    {
        Console.WriteLine($"fornisci 2 numeri");
        int età = int.Parse(Console.ReadLine());
        float altezza = float.Parse(Console.ReadLine());
        int circaltezza = (int)altezza;

        Console.WriteLine($"\n---- Operazione Aritemetica\n");
        int sum = età + circaltezza;
        Console.WriteLine($"Somma di età + altezza = {sum}");
    }
    public static void SCExemples()
    {
        Console.Write($"Inserici il Primo Numero");
        int a = int.Parse(Console.ReadLine());
        Console.Write($"Inserici il Secondo Numero");
        int b = int.Parse(Console.ReadLine());


        
        if(a < b && a > 2)
        {
            Console.WriteLine($"{a} minore di {b}");
        }
        else if (a > b)
        {
            Console.WriteLine($"{a} maggiore di {b}");
        }
        else if (a != b)
        {
            Console.WriteLine($"{a} diverso di {b}");
        }
        else
        {
            Console.WriteLine($"{a} uguale a {b}");
        }
    }
    
    public static void EsercizioIFELSE1pag38()
    {
        Console.WriteLine($"inserisci la tua età");
        int età = int.Parse(Console.ReadLine());

        if(età >= 18)
        {
            Console.WriteLine($"maggiorenne");
        }
        else
        {
            Console.WriteLine($"minorenne");
        }
    }

    public static void EsercizioIFELSE2pag38()
    {
        Console.Write($"Diciarare il Prezzo del Prodotto");
        float Prezzo = float.Parse(Console.ReadLine());

        if(Prezzo > 100.000)
        {
            int sconto = 80;
            int scontocirca = (int)sconto;
            float PrezzoScontato = Prezzo - (Prezzo * scontocirca / 100);
            Console.Write($"il conto ammonta a {PrezzoScontato:F2} perhcè ai speso più di 100€");
        }
        else
        {
            Console.Write($"il conto ammota a {Prezzo}€");
        }
    }

    public static void EsercizioIFELSE3pag39 ()
    {
        Console.WriteLine($"Scrivi Tre Numeri Interi");
        int N1 = int.Parse(Console.ReadLine());
        int N2 = int.Parse(Console.ReadLine());
        int N3 = int.Parse(Console.ReadLine());
        int sum = N1 + N2 + N3;
        double media = (double)sum / 3;

        if(media >= 60)
        {
            Console.WriteLine($"hai superato la prova!");
            Console.WriteLine($"risultato {media:F2}");
        }
        else
        {
            Console.WriteLine($"prova fallita");
            Console.WriteLine($"risultato {media:F2}");
        }
    }
    public static void EsercizioIFELSE4pag41()
    {
        
    }
}
