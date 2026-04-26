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
        Compiti1();
        Compiti2();
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
        // Console.WriteLine($"\n---- OperazioneAritmetica");
        // int a = 20;
        // int b = 30;
        // int sum = a + b;
        // Console.WriteLine($"prodotto di a + b = {sum}");
        // double discount =20% // MODIFICATO PER ESIGENZA
        // Console.WriteLine($"prodotto di a + b = {sum} - discount");
        // float check = 60;
        // Console.WriteLine($"prodotto di a + b = {sum} - discount");
}  
    public static void Compiti2 ()
    {
        Console.WriteLine($"fornisci 2 numeri");
        int età = int.Parse(Console.ReadLine());
        float altezza = float.Parse(Console.ReadLine());
        int circaltezza = (int)altezza;

        Console.WriteLine($"\n---- Operazione Aritemetica\n");
        int sum = età + circaltezza;
        Console.WriteLine($"Somma di età + altezza = {sum}");
    }
}