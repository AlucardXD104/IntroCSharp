public class Veicolo
{
    public string Targa="";
    public virtual void Ripara()
    {
        Console.WriteLine($"Il Veicolo Viene Controllato");
    }
    public Veicolo(string targa)
    {
        Targa = targa;
    }
}
class Auto : Veicolo
{
        public Auto(string targa) : base(targa){}
    public override void Ripara()
    {
        Console.WriteLine($"Controllo Olio, Freni e Motore");
    }
}
class Moto : Veicolo
{
        public Moto(string targa) : base(targa){}
    public override void Ripara()
    {
        Console.WriteLine($"Controllo catena, Freni e Gomme");
    }
}
class Camion : Veicolo
{
        public Camion(string targa) : base(targa){}
    public override void Ripara()
    {
        Console.WriteLine("Controllo Sospensioni, Freni rinforzati e Carico del camion");
    }
}