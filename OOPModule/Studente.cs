using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

public class studente2
{
    //Attributi
    public string Nome ="";
    public int Voto1;
    public int Voto2;

    //Metodi
public double Media(int Bonus)
    {
        int Voto1Bonus=Voto1 + Bonus;
        int Voto2Bonus=Voto2 + Bonus;
        if (Voto1Bonus > 10)
        {
            Voto1Bonus=10;
        }
        if(Voto2Bonus < 10)
        {
            Voto2Bonus=10;
        }
        int Somma = Voto1Bonus + Voto2Bonus;
        double Media = Somma/2;
        return Media;
    }
    public override string ToString()
    {
        return $"studente {Nome} ha la seguente Media {Media}";
    }
    public override bool Equals(object? obj)
    {
        if(obj is studente2 other)
        {
            return Nome==other.Nome;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Nome);
    }
    //Non Merito di vivere, sotto il suo stesso sole prof
}