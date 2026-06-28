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
    public override string ToString()
    {
        return $"Il Titolo del Libro è {Nome} dell'Autore {Autore} Publicato l'Anno {AnnoDiPubblicazione}";
    }
    public override bool Equals(object? obj)
    {
        if(obj is Libro other)
        {
            return Nome==other.Nome && Autore==other.Autore;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Nome, Autore, AnnoDiPubblicazione);
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
    public override string ToString()
    {
        return $"La macchina di {NomeUtente}, Ha la Seguente Componentistica \n Motore: {Motore}\n Velocità: {VelocitaMax}\n Sospensioni: {SospensioniMax}\n La Macchina di {NomeUtente} è stata modificata {NrModificate} Volte\n il Credito Rimanente è {Credito}";
    }
    public override bool Equals(object? obj)
    {
        if(obj is Macchina other)
        {
            return Motore==other.Motore && NomeUtente==other.NomeUtente;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(NomeUtente,Motore,VelocitaMax);
    }
}
class Film
{
//Attributi
public string Titolo= "";
public string Regista="";
public int Anno;
public string Genere="";

//Metodi
    public void Generi()
    {
        List<string> videoTeca = new List<string>();
        videoTeca.Add("Supereroistico");
        videoTeca.Add("Horror");
        videoTeca.Add("Azione");
        videoTeca.Add("Romantico");
        videoTeca.Add("Animazione");
        videoTeca.Add("Fantasy");
        //Funzionare funziona, Ma la lista per come o svolto l'esercizio non serve a nulla e non saprei come implementarla.
    }
}