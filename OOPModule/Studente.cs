using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

class studente2()
{
    //Attributi
        public string Nome="";
        public int Voto1;
        public int Voto2;
        public void Valori(ref string Nome,int Voto1,int Voto2)
    {
        Voto1++;
        Voto2++;
        Console.WriteLine($"Ciao, Mi Chiamo {Nome}");
        Console.WriteLine($"Bonus Voti {Voto1} e {Voto2}");
    }
}