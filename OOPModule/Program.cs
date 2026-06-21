using System.Data;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

public class Program
{
public static void Main(string[] args)
{
            //     [MAINS]
            // MainCane();
            // MainStudente();
            // MainPersona();
            // MainCalcolatrice();
            // MainStudente2();
            // MainLibro();
            // MainMacchina();
            // MainFilm();

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
        studente2 S1 = new studente2();
        string Nome ="Bartolomeo";
        int V1 = 4;
        int V2 = 3;
        // S1.Valori(ref V1);
        // S1.Valori(ref V2);
    }
    public static void MainLibro()
    {
        Libro Libro1 = new Libro();
        Libro1.Nome = "Come L'acqua";
        Libro1.Autore = "Pietro Eustachio Peloso";
        Libro1.AnnoDiPubblicazione = 1999;
        
        Libro1.Libreria();

        Libro Libro2 = new Libro();
        Libro2.Nome = "Il Gufo dell'Ungheria";
        Libro2.Autore = "Zoltàn Horváth";
        Libro2.AnnoDiPubblicazione = 1267;

        Libro2.Libreria();

        Libro Libro3 = new Libro();
        Libro3.Nome = "Come L'acqua";
        Libro3.Autore = "Pietro Eustachio Peloso";
        Libro3.AnnoDiPubblicazione = 2015;

        Libro3.Libreria();

        if (Libro1.Nome.Equals(Libro3.Nome))
        {
            if (Libro1.Autore.Equals(Libro3.Autore))
            {
                Console.WriteLine($"il Primo e il Terzo libro Sono uguali");
            }
            else
            {
                Console.WriteLine($"il Primo e il Terzo libro Sono diversi");
            }
        }
        Console.WriteLine($"HasCode Libro1: {Libro1.GetHashCode()}");
        Console.WriteLine($"HasCode Libro2: {Libro2.GetHashCode()}");
        Console.WriteLine($"HasCode Libro3: {Libro3.GetHashCode()}");
    }
    public static void MainMacchina()
    {
        Macchina Utente1 = new Macchina();
        Console.WriteLine($"Inserisci il tuo Nome");
        Console.Write($"Nome: ");
        Utente1.NomeUtente = Console.ReadLine();
        Utente1.Credito = 3;
        Utente1.Motore ="VolkSvagen";
        Utente1.VelocitaMax = 130.90f;
        Utente1.SospensioniMax = 8;
        Utente1.NrModificate = 0;

        if (Utente1.NomeUtente != string.Empty)
        {
            Console.WriteLine($"Benvenuto {Utente1.NomeUtente} il tuo Crdito è di {Utente1.Credito} Punti");
            Console.WriteLine($"La Tua Macchina ha i seguenti componenti:\n Motore: {Utente1.Motore}\n Velocità: {Utente1.VelocitaMax}\n Sospensioni: {Utente1.SospensioniMax}\n Numero Modifiche: {Utente1.NrModificate} ");
            Console.WriteLine($"Ora Modifica la tua macchina");
            Console.WriteLine($"Scegli un Nuovo Motore:");
            Console.WriteLine($"Credito Rimanente: {Utente1.Credito}");
            Utente1.Motore = Console.ReadLine();
            Utente1.Credito--;
            Utente1.NrModificate++;
            Console.WriteLine($"Aumenta la Velocita Massima Fino ad un Massimo di 10:");
            Console.WriteLine($"Credito Rimanente: {Utente1.Credito}");
            Utente1.VelocitaMax = float.Parse(Console.ReadLine());
            Utente1.Credito--;
            Utente1.NrModificate++;
            Console.WriteLine($"Aumenta il Livello Massimo delle sospensioni di 1:");
            Console.WriteLine($"Credito Rimanente: {Utente1.Credito}");
            Utente1.SospensioniMax = int.Parse(Console.ReadLine());
            Utente1.Credito--;
            Utente1.NrModificate++;

            Utente1.Garage();
        }
        else
        {
            Console.WriteLine($"Credenziali non valide (Fottiti)");
        }


        Macchina Utente2 = new Macchina();
        Console.WriteLine($"Inserisci il tuo Nome");
        Console.Write($"Nome: ");
        Utente2.NomeUtente = Console.ReadLine();
        Utente2.Credito = 3;
        Utente2.Motore ="Citroen";
        Utente2.VelocitaMax = 110.40f;
        Utente2.SospensioniMax = 5;
        Utente2.NrModificate = 0;

        if (Utente2.NomeUtente != string.Empty)
        {
            Console.WriteLine($"Benvenuto {Utente2.NomeUtente} il tuo Crdito è di {Utente2.Credito} Punti");
            Console.WriteLine($"La Tua Macchina ha i seguenti componenti:\n Motore: {Utente2.Motore}\n Velocità: {Utente2.VelocitaMax}\n Sospensioni: {Utente2.SospensioniMax}\n Numero Modifiche: {Utente2.NrModificate} ");
            Console.WriteLine($"Ora Modifica la tua macchina");
            Console.WriteLine($"Scegli un Nuovo Motore:");
            Console.WriteLine($"Credito Rimanente: {Utente2.Credito}");
            Utente2.Motore = Console.ReadLine();
            Utente2.Credito--;
            Utente2.NrModificate++;
            Console.WriteLine($"Aumenta la Velocita Massima Fino ad un Massimo di 10:");
            Console.WriteLine($"Credito Rimanente: {Utente2.Credito}");
            Utente1.VelocitaMax = float.Parse(Console.ReadLine());
            Utente1.Credito--;
            Utente1.NrModificate++;
            Console.WriteLine($"Aumenta il Livello Massimo delle sospensioni di 1:");
            Console.WriteLine($"Credito Rimanente: {Utente2.Credito}");
            Utente1.SospensioniMax = int.Parse(Console.ReadLine());
            Utente1.Credito--;
            Utente1.NrModificate++;

            Utente2.Garage();

        }
        else
        {
            Console.WriteLine($"Credenziali non valide (Fottiti)");
        }

        Macchina Utente3 = new Macchina();
        Console.WriteLine($"Inserisci il tuo Nome");
        Console.Write($"Nome: ");
        Utente1.NomeUtente = Console.ReadLine();
        Utente3.Credito = 3;
        Utente3.Motore ="Ferrari";
        Utente3.VelocitaMax = 215.80f;
        Utente3.SospensioniMax = 3;
        Utente3.NrModificate = 0;

        if (Utente1.NomeUtente != string.Empty)
        {
            Console.WriteLine($"Benvenuto {Utente3.NomeUtente} il tuo Crdito è di {Utente3.Credito} Punti");
            Console.WriteLine($"La Tua Macchina ha i seguenti componenti:\n Motore: {Utente3.Motore}\n Velocità: {Utente3.VelocitaMax}\n Sospensioni: {Utente3.SospensioniMax}\n Numero Modifiche: {Utente3.NrModificate} ");
            Console.WriteLine($"Ora Modifica la tua macchina");
            Console.WriteLine ($"Scegli un Nuovo Motore:");
            Console.WriteLine($"Credito Rimanente: {Utente2.Credito}");
            Utente1.Motore = Console.ReadLine();
            Utente1.Credito--;
            Utente1.NrModificate++;
            Console.WriteLine($"Aumenta la Velocita Massima Fino ad un Massimo di 10:");
            Console.WriteLine($"Credito Rimanente: {Utente3.Credito}");
            Utente1.VelocitaMax = float.Parse(Console.ReadLine());
            Utente1.Credito--;
            Utente1.NrModificate++;
            Console.WriteLine($"Aumenta il Livello Massimo delle sospensioni di 1:");
            Console.WriteLine($"Credito Rimanente: {Utente3.Credito}");
            Utente1.SospensioniMax = int.Parse(Console.ReadLine());
            Utente1.Credito--;
            Utente1.NrModificate++;

            Utente3.Garage();
        }
        else
        {
            Console.WriteLine($"Credenziali non valide (Fottiti)");
        }
    }
    public static void MainFilm()
    {
        //I Give up
    }
}