using System.Net.Mail;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

class Studente
{
    //Attributi
    public string Nome="";
    public int Matricola;
    public double MediaVoti;

    //Comportamenti
    public void Saluta()
    {
        Console.WriteLine($"Ciao, sono {Nome}, Matricola {Matricola} e la Media dei miei Voti è {MediaVoti}");
    }
}
class Persona
{
    //Attributi
    public string Nome="";
    public string Cognome="";
    public int AnnoNascita;

    //Comportamenti

    public void Presentazione()
    {
        Console.WriteLine($"Salve sono {Nome} {Cognome} e sono nata nel {AnnoNascita}");
    }
}
class Calcolatrice
{
    //Attributi
    public int intA;
    public int intB;
    public string Segno ="";

    //Comportamenti
    public void Risultato()
    {
        if(Segno == "+")
        {
            Console.WriteLine($"La Somma tra {intA} e {intB} è {intA + intB}");
        }
        else if(Segno == "*")
        {
            Console.WriteLine($"il Prodotto tra {intA} e {intB} è {intA * intB}");
        }
        else
        {
            Console.WriteLine($"Il segno non è al momento Presente");
        }
    }
}
class Libro
{
    //Attributi
    public string Nome ="";
    public string Autore ="";
    public int AnnoDiPubblicazione;

    //Comportamenti
    public void Libreria()
    {
        Console.WriteLine($"Il Titolo del Libro è {Nome.ToString()} dell'Autore {Autore} Publicsto l'Anno {AnnoDiPubblicazione}");
    }
}
class Macchina
{
    //Attributi
    public string NomeUtente="";
    public int Credito;

    public string Motore ="";
    public float VelocitaMax;
    public int SospensioniMax;
    public int NrModificate;

    //Comportamenti
    public void Garage()
    {
        Console.WriteLine($"La macchina di {NomeUtente}, Ha la Seguente Componentistica \n Motore: {Motore}\n Velocità: {VelocitaMax}\n Sospensioni: {SospensioniMax}\n La Macchina di {NomeUtente} è stata modificata {NrModificate} Volte\n il Credito Rimanente è {Credito}");
    }
}
class Film
{
    //I Give up
}