public class Veicolo
{
    private string Targa="";
    public virtual void Ripara()
    {
        Console.WriteLine($"Il Veicolo Viene Controllato");
    }
    public Veicolo(string Targa)
    {
        Targa = Targa;
    }
}
class Auto : Veicolo
{
    public override void Ripara()
    {
        Console.WriteLine($"Controllo Olio, Freni e Motore");
    }
}
class Moto : Veicolo
{
    public override void Ripara()
    {
        Console.WriteLine($"Controllo catena, Freni e Gomme");
    }
}
class Camion : Veicolo
{
    public override void Ripara()
    {
        Console.WriteLine("Controllo Sospensioni, Freni rinforzati e Carico del camion");
    }
}