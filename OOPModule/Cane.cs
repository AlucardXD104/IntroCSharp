using System.ComponentModel;

class Cane
{
    //Attributi
    public string nome ="";
    public int eta;

    //Costruttori
    public Cane()
    {
        Console.WriteLine($"e stato instanziato un nuovo cane");
    }
    public Cane(string nome, int eta)
    {
        this.nome = nome;
        this.eta = eta;
    }

    //Comportamenti
    public void Abbabia()
    {
        Console.WriteLine($"Il cane di nome {nome} e di età {eta}, sta abbaiando");
    }
}