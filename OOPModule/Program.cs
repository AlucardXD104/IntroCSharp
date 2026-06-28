using System.Data;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Security.Cryptography;
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
            MainFilm();
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
        studente2 Tizio1 = new studente2();
        Console.Write($"Ciao, Inserisci il tuo Nome: ");
        Tizio1.Nome=Console.ReadLine();
        Random rnd = new Random();
        Tizio1.Voto1=rnd.Next(0,11);
        Tizio1.Voto2=rnd.Next(0,11);
    }
    public bool ElaboraStudente(studente2 stu, int Bonus, ref int Voto1, ref int Voto2)
    {
        double Med=stu.Media(Bonus);
        if (Med >= 6)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //Spostsa Media int qua, e cambia int Voto=Voto + Bonus, in Voto+=Bonus.
    public static void MainLibro()
    {
        Libro Libro1 = new Libro();
        Libro1.Nome = "Come L'acqua";
        Libro1.Autore = "Pietro Eustachio Peloso";
        Libro1.AnnoDiPubblicazione = 1999;
        
        Console.WriteLine($"{Libro1}");
        

        Libro Libro2 = new Libro();
        Libro2.Nome = "Il Gufo dell'Ungheria";
        Libro2.Autore = "Zoltàn Horváth";
        Libro2.AnnoDiPubblicazione = 1267;

        Console.WriteLine($"{Libro2}");


        Libro Libro3 = new Libro();
        Libro3.Nome = "Come L'acqua";
        Libro3.Autore = "Pietro Eustachio Peloso";
        Libro3.AnnoDiPubblicazione = 2015;

        Console.WriteLine($"{Libro3}");



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
            Console.WriteLine($"{Utente1}");
            
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
            Console.WriteLine($"{Utente2}");
            
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
            Console.WriteLine($"{Utente3}");

        }
        else
        {
            Console.WriteLine($"Credenziali non valide (Fottiti)");
        }
    }
    public static void MainFilm()
    {
        Film Film1 = new Film();
        Film1.Titolo ="La Parla di Pacciani";
        Film1.Regista ="Rosario Bevacqua e Pietro Fioravanti";
        Film1.Anno = 2028;
        Film1.Genere = "Supereroistico";

        Film Film2 = new Film();
        Film2.Titolo ="Titanic";
        Film2.Regista ="James Cameron";
        Film2.Anno = 1998;
        Film2.Genere = "Romantico";

        Film Film3 = new Film();
        Film3.Titolo ="Mission Impossible";
        Film3.Regista ="Brian De Palma";
        Film3.Anno = 1996;
        Film3.Genere = "Azione";

        Film Film4 = new Film();
        Film4.Titolo ="I Signore degli Anelli, La Compagnia dell'Anello";
        Film4.Regista ="Peter Jekson";
        Film4.Anno = 2002;
        Film4.Genere = "Fantasy";

        Film Film5 = new Film();
        Film5.Titolo ="Shrek";
        Film5.Regista ="Andrew Adamson e Vicky Jenson";
        Film5.Anno = 2001;
        Film5.Genere = "Animazione";

        Film Film6 = new Film();
        Film6.Titolo ="Halloween";
        Film6.Regista ="John Carpenter";
        Film6.Anno = 1979;
        Film6.Genere = "Horror";

        Film Film7 = new Film();
        Film7.Titolo ="Jhon Wick";
        Film7.Regista ="Chad Stahelski";
        Film7.Anno = 2015;
        Film7.Genere = "Azione";

        Film Film8 = new Film();
        Film8.Titolo ="Superman";
        Film8.Regista ="James Gunn";
        Film8.Anno = 2025;
        Film8.Genere = "Supereroistico";

        Film Film9 = new Film();
        Film9.Titolo ="Evil Dead";
        Film9.Regista ="Sam Raimi";
        Film9.Anno = 1981;
        Film9.Genere = "Horror";

        Console.Write($"Scegli un genere di film tra: \n 1-Supereroistico \n 2-Horror \n 3-Azione \n 4-romantico \n 5-Animazione \n 6-Fantasy \n\n scrivi:");
        {
            switch (Console.ReadLine())
            {
                case "Supereroistico":
                Console.WriteLine("Film di Genere Supereroistico:");
                Console.WriteLine($"Titolo:{Film1.Titolo}\n Regista:{Film1.Regista}\n Anno:{Film1.Anno}");
                break;

                case "Horror":
                Console.WriteLine("Film di Genere Horror:");
                Console.WriteLine($"Titolo:{Film6.Titolo}\n Regista:{Film6.Regista}\n Anno:{Film6.Anno}");
                Console.WriteLine("-----------------");
                Console.WriteLine($"Titolo:{Film9.Titolo}\n Regista:{Film9.Regista}\n Anno:{Film9.Anno}");
                break;

                case"Azione":
                Console.WriteLine("Film di Genere Azione:");
                Console.WriteLine($"Titolo:{Film3.Titolo}\n Regista:{Film3.Regista}\n Anno:{Film3.Anno}");
                Console.WriteLine("-----------------");
                Console.WriteLine($"Titolo:{Film7.Titolo}\n Regista:{Film7.Regista}\n Anno:{Film7.Anno}");
                break;

                case"Romantico":
                Console.WriteLine("Film di Genere Romantico:");
                Console.WriteLine($"Titolo:{Film2.Titolo}\n Regista:{Film2.Regista}\n Anno:{Film2.Anno}");
                break;

                case"Animazione":
                Console.WriteLine("Film di Genere Animazione:");
                Console.WriteLine($"Titolo:{Film5.Titolo}\n Regista:{Film5.Regista}\n Anno:{Film5.Anno}");
                break;

                case"fantasy":
                Console.WriteLine("Film di Genere Fantasy:");
                Console.WriteLine($"Titolo:{Film4.Titolo}\n Regista:{Film4.Regista}\n Anno:{Film4.Anno}");
                break;
            }
        }
    }
}