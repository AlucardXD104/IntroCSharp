using System.Data;

public class Program
{
 public static void Main(string[] args)
 {
            //     [MAINS]
            // MainCane();
            // MainStudente();
            // MainPersona();
            // MainCalcolatrice();
            MainStudente2();
}
    public static void MainCane()
    {
            Cane cane1 = new Cane();

            cane1.nome = "Fido";
            cane1.eta = 10;

            cane1.Abbabia();

            Cane cane2 = new Cane();

            cane2.nome = "Patrixio";
            cane2.eta = 5;

            cane2.Abbabia();

            Cane cane3 = new Cane("Lessie", 6);
            cane3.Abbabia();  
    }
    public static void MainStudente()
    {
        Studente studente1 = new Studente();
        studente1.Nome="Franco";
        studente1.Matricola = 3;
        studente1.MediaVoti = 7.9;

        studente1.Saluta();

        Studente studente2 = new Studente();
        studente2.Nome="Pierclaudio";
        studente2.Matricola = 58;
        studente2.MediaVoti = 2.1;

        studente2.Saluta();
    }
    public static void MainPersona()
    {
            Persona Persona1 = new Persona();
            Persona1.Nome = "Tizziana";
            Persona1.Cognome = "jeancojon";
            Persona1.AnnoNascita = 1956;

            Persona1.Presentazione();

            Persona Persona2 = new Persona();
            Persona2.Nome = "Calabella";
            Persona2.Cognome = "Pompadur";
            Persona2.AnnoNascita = 2016;

            Persona2.Presentazione();
    }
    public static void MainCalcolatrice()
    {
            Calcolatrice Calcolo1 = new Calcolatrice();
            Console.WriteLine($"Inserici 2 Numeri");
            Calcolo1.intA = int.Parse(Console.ReadLine());
            Calcolo1.intB = int.Parse(Console.ReadLine());

            Console.WriteLine($"Inserisci un segno fra + e *");
            Calcolo1.Segno = Console.ReadLine();

            Calcolo1.Risultato();
    }
    public static void MainStudente2()
    {
        studente2 S = new studente2();
        int V1 = 4;
        int V2 = 3;
    }
}