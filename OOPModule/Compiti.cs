using System.Net.Mail;
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