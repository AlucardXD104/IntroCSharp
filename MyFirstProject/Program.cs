using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Net.Mail;
using System.Runtime.Intrinsics.Arm;
using System.Security;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static int age = 30;
    static int Age = 50;
    

    public static void Main(string[] args)
    {
        // Console.WriteLine ("Hello, world");
        // Console.WriteLine("age: " + age);
        // Console.WriteLine("Age: " + Age);
        // int num1 = 10;
        // float num2 = num1; 
        // Console.WriteLine($"num1 {num2} --- num2 {num2}");
        // float num3 = 12.45677f;
        // int num4 = (int)num3;
        // Console.WriteLine($"num3 {num3} --- num4 {num4}");

        // ReadLineExamples();
        // VariableOperationsExamples();
        // Compiti1();
        // Esercizio2();
        // Esercizio3();
        // Esercizio4();
        // SCExemples();
        // EsercizioIFELSE1pag38();
        // EsercizioIFELSE2pag38();
        // EsercizioIFELSE3pag39();
        // EsercizioIFELSE4pag41();
        // EsercizioIFELSE5pag42();
        // EsercizioIFELSE6pag45();
        // EsercizioIFELSE7pag45();
        // EsercizioIFELSE8pag46();
        // Es1pag48();
        // Es1pag54();
        // Es2pag54();
        // Es1pag55();
        // Es1pag57();
        // Es2pag57();
        // Es3pag57();
        // Es1pag59();
        // Es2pag59();
        // Es1pag114();
        // EsercizioComplessivo_Do_While_For();
        // Es1pag76();
        // Es2pag76();
        // Es3pag76();
        // Es1pag113();
        // MatrixExemple();
        // MainDiagonal();
        // Es1Pag114();
        Es2Pag114();
    }

    public static void ReadLineExamples()
    {
        // Console.Write($"Dì il tuo nome e congniome: ");
        // string? name = Console.ReadLine();

        // Console.WriteLine($"Il Tuo Nome è {name}");

        // Console.Write("inserisci n1");
        // string? n1 = Console.ReadLine();

        // Console.Write("inserisci n2");
        // string? n2 = Console.ReadLine();

        // Console.Write("inserisci n2");
        // string? n3 = Console.ReadLine();

        // int number1 = int.Parse(n1);
        // int number2 = int.Parse(n2);
        // int number3 = int.Parse(n3);

        // Console.WriteLine($"Somma number1 + number2 - number3 = {number1 + number2 - number3}");
    }
    public static void VariableOperationsExamples()
    {
    //    Console.WriteLine($"Inserici 2 numeri");
    //    int a = int.Parse(Console.ReadLine());
    //    int b = int.Parse(Console.ReadLine());

    //    Console.WriteLine($"\n---- Operazione Aritemetica\n");
    //    int sum = a + b;
    //    Console.WriteLine($"Somma di A + B = {sum}");
    //    int diff = a - b;
    //    Console.WriteLine($"Sottrazione di A - B = {diff}");
    //    double div = a / b;
    //    Console.WriteLine($"Divisione di A / B = {div}");
    //    int prod = a * a;
    //    Console.WriteLine($"Prodotto di A * B = {prod}");
    //    int resto = a % b;
    //    Console.WriteLine($"Resto di A e B = {resto}");

    } 
    public static void Compiti1 ()
{
    // SBAGLIATO/NON FINITO
        Console.WriteLine($"\n---- OperazioneAritmetica");
        int a = 20;
        int b = 30;
        int sum = a + b;
        Console.WriteLine($"prodotto di a + b = {sum}");
}  
    public static void Esercizio2()
    {
        double discount = 20;
        double price = 100;
        double discountedPrice = price - (price * discount / 100);
        //prezzo - (prezzo * disocunt / 100)
        Console.WriteLine($" totale prodotto scontato = {discountedPrice}");
    
    }
    public static void Esercizio3()
    {
        float a = 10.567f;
        bool isPositive = a >= 0;
        Console.WriteLine($"{a} è Positivo? {isPositive}");
    }
    public static void Esercizio4 ()
    {
        Console.WriteLine($"fornisci 2 numeri");
        int età = int.Parse(Console.ReadLine());
        float altezza = float.Parse(Console.ReadLine());
        int circaltezza = (int)altezza;

        Console.WriteLine($"\n---- Operazione Aritemetica\n");
        int sum = età + circaltezza;
        Console.WriteLine($"Somma di età + altezza = {sum}");
    }
    public static void SCExemples()
    {
        Console.Write($"Inserici il Primo Numero");
        int a = int.Parse(Console.ReadLine());
        Console.Write($"Inserici il Secondo Numero");
        int b = int.Parse(Console.ReadLine());


        
        if(a < b && a > 2)
        {
            Console.WriteLine($"{a} minore di {b}");
        }
        else if (a > b)
        {
            Console.WriteLine($"{a} maggiore di {b}");
        }
        else if (a != b)
        {
            Console.WriteLine($"{a} diverso di {b}");
        }
        else
        {
            Console.WriteLine($"{a} uguale a {b}");
        }
    }    
    public static void EsercizioIFELSE1pag38()
    {
        Console.WriteLine($"inserisci la tua età");
        int età = int.Parse(Console.ReadLine());

        if(età >= 18)
        {
            Console.WriteLine($"maggiorenne");
        }
        else
        {
            Console.WriteLine($"minorenne");
        }
    }
    public static void EsercizioIFELSE2pag38()
    {
        Console.Write($"Diciarare il Prezzo del Prodotto");
        float Prezzo = float.Parse(Console.ReadLine());

        if(Prezzo > 100.000)
        {
            int sconto = 80;
            int scontocirca = (int)sconto;
            float PrezzoScontato = Prezzo - (Prezzo * scontocirca / 100);
            Console.Write($"il conto ammonta a {PrezzoScontato:F2} perhcè ai speso più di 100€");
        }
        else
        {
            Console.Write($"il conto ammota a {Prezzo}€");
        }
    }
    public static void EsercizioIFELSE3pag39()
    {
        Console.WriteLine($"Scrivi Tre Numeri Interi");
        int N1 = int.Parse(Console.ReadLine());
        int N2 = int.Parse(Console.ReadLine());
        int N3 = int.Parse(Console.ReadLine());
        int sum = N1 + N2 + N3;
        double media = (double)sum / 3;

        if(media >= 60)
        {
            Console.WriteLine($"hai superato la prova!");
            Console.WriteLine($"risultato {media:F2}");
        }
        else
        {
            Console.WriteLine($"prova fallita");
            Console.WriteLine($"risultato {media:F2}");
        }
    }
    public static void EsercizioIFELSE4pag41()
    {
        Console.WriteLine($"Inserire password");
        string utente = (Console.ReadLine());
        string password = "maurizio";
        
        if(utente == password)
        {
            Console.WriteLine($"accesso consentito");
        }
        else
        {
            Console.WriteLine($"accesso negato");
        }
    }
    public static void EsercizioIFELSE5pag42()
    {
        //NON O CAPITO?
    }
    public static void EsercizioIFELSE6pag45()
    {
        Console.WriteLine($"inserisci un numero da 1 a 10");   
        int Voto = int.Parse(Console.ReadLine());
        
        if(Voto >= 1 && Voto <=4)
        {
            Console.WriteLine($"insufficente");
        }
        else if (Voto >= 5 && Voto <= 6)
        {
            Console.WriteLine($"sufficente");
        }

        else if (Voto >= 7 && Voto <= 8)
        {
            Console.WriteLine($"buono");
        }

        else if (Voto >= 9 && Voto <= 10)
        {
            Console.WriteLine($"ottimo");
        }
    }
    public static void EsercizioIFELSE7pag45()
    {
        Console.WriteLine($"Inserisci il Tuo BMI");
        float Altezza = float.Parse(Console.ReadLine());
        float Peso = float.Parse(Console.ReadLine());
        float BMI = Peso /(Altezza*Altezza);
        Console.WriteLine($"BMI {BMI}");
            if(BMI < 18.5)
        {
                Console.WriteLine($"sottopeso");
        }
            else if (18.5 <= BMI && BMI < 25)
        {
                Console.WriteLine($"Normopeso");
        }
            else if (25 <= BMI && BMI < 30)
        {
                Console.WriteLine($"sovrappeso");
        }
            else 
        {
                Console.WriteLine($"Obesità");
        }  
    }
    public static void EsercizioIFELSE8pag46()
    {
        Console.WriteLine($"inserisci una temperatura");
        float temperatura = float.Parse(Console.ReadLine());
        Console.WriteLine($"hai insrtito {temperatura} Celsius");
        Console.WriteLine($"ora scegli in quale altra schala convertirla");

        Console.WriteLine($"Digita 1 se vuoi la scala Fahrenheit, 2 per la Kelvine e 3 per la Rankine");
        int Scelta = int.Parse(Console.ReadLine());
        if ( Scelta == 1)
        {
            Console.WriteLine($"{temperatura} Fahrenheit");
        }
        else if (Scelta == 2)
        {
            Console.WriteLine($"{temperatura} Krlvine");
        }
        else
        {
            Console.WriteLine($"{temperatura} Rankine");
        }
    }
    public static void Es1pag48()
    {
        Console.WriteLine($"Inserisci un Numero da 1 a 7");
        
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine($"è Lunedi");
                break;

            case "2":
                Console.WriteLine($"è Martedi");
                break;

            case "3":
                Console.WriteLine($"è Mercoledì");
                break;

            case "4":
                Console.WriteLine($"è Giovedì");
                break;

            case "5":
                Console.WriteLine($"è Venerdì");
                break;

            case "6":
                Console.WriteLine($"è Sabato");
                break;

            case "7":
                Console.WriteLine($"è Domenica");
            break;

            default:
                Console.WriteLine($"Ti o chiesto numeri tra 1 e 7, scemo");
            break;
        }
    }
    public static void Es1pag54()
    {
        Console.WriteLine($"Inserisci dei numeri interi positivi");
        int numero = 0,somma = 0;


        while (numero >= 0 && numero <= 100)
        {
            Console.WriteLine($"Inserisci un numero intero positivo");
            numero = int.Parse(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine($"Sbagliato");
            }
            else
            {
                somma += numero;
            }
        }
        Console.WriteLine($"La somma dei numeri inseriti è {somma}");
    }
    public static void Es2pag54()
    {
        Console.WriteLine($"Indovina il numero segreto Fra 0 e 20");
        int NumeroS = 11;
        int Risposta = NumeroS;
        while (Risposta == NumeroS)
        {
            Risposta = int.Parse(Console.ReadLine());
            if(Risposta > NumeroS)
            {
                Console.WriteLine($"il Numero {Risposta} Troppo alto, Riprova");
            }
            else if (Risposta < NumeroS)
            {
                Console.WriteLine($"il Numero {Risposta} Troppo Basso, Riprova");
            }
            else
            {
                Console.WriteLine($"Hai Indovinato!!");
            }
        }
    }
    public static void Es1pag55()
    {
        Console.Write($"Digita il numero corrispondente al'oppzione desiderata");
        Console.WriteLine($"1 Visualizza Saldo-2 Deposita Denaro-3 Preleva denaro-4 Esci");
        int VisualizzaConto = 1;
        int DepositaDenaro = 2;
        int PrelevaDenaro = 3;
        int Risposta = 0;

        while (Risposta == 0)
        {
            Risposta = int.Parse(Console.ReadLine());
            if(Risposta == VisualizzaConto)
            {
                Console.WriteLine($"Accesso al Conto Effettuato");
            }
            else if(Risposta == DepositaDenaro)
            {
                Console.WriteLine($"Accesso al Deposito Effettuato");
            }
            else if(Risposta == PrelevaDenaro)
            {
                Console.WriteLine($"Effettuato Prelievo di Denaro");
            }
            else
            {
                Console.WriteLine($"Sei Uscito con Successo");
            }
        }
    }
    public static void Es1pag57()
    {
        Console.WriteLine($"Inserisci Password");
        int Password = 2567;
        int NTentativi = 3;
        bool accesso = false;
        do
        {
            int Verifica = int.Parse(Console.ReadLine());
            if (Password == Verifica)
            {
                Console.WriteLine($"Accesso Consentito");
                accesso = true;
            }
            else
            {
                NTentativi--;
                Console.WriteLine($"Accesso Negato");
            }
            Console.WriteLine($"{NTentativi}");
        }  
        while (accesso == false && NTentativi > 0);
    }
    // public static void Es2pag57 ()
    // {
    //     Console.WriteLine($"Inserisci numeri interi, se inserisci lo zero annulli il programma");
    //     bool Esci = false;

    //     do
    //     {
    //         int Numeri = int.Parse(Console.ReadLine());

    //     }
    //     while ()
    // }
    // public static void Es3pag57 ()
    // {
    //     Console.WriteLine($"chiedi una operazione");
    //     bool esci = false;
    //     do
    //     {
    //         int N1 = int.Parse(Console.ReadLine());
    //         int N2 = int.Parse(Console.ReadLine());
    //         if ()
    //     }
    //     while (esci == false);
    // }
    public static void Es1pag59()
    {
        Console.WriteLine($"inserisci il numero e ti dirò la sua tabella");
        int N1 = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{N1} * {i}={N1 * i}");
        }
    }
    public static void Es2pag59()
    {
        Console.WriteLine($"quanti numeri vuoi inserire?");
        int volte = int.Parse(Console.ReadLine());
        int somma = 0;
        for (int i = 0; i < volte; i++)
        {
            Console.Write($"inserisci numero: ");
            somma += int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Media dei Valori = {somma / volte}");
    }
    public static void Es1pag114()
    {
        Console.WriteLine($"Inserisci una serie di numeri");
        int lunghezza = int.Parse(Console.ReadLine());
        int[] numeri = new int[lunghezza];
        int somma = 0;
        for(int i = 0; i < lunghezza; i++)
        {
            Console.WriteLine($"inserisci un Numero: ");
            somma += int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Somma Dei Dati Inseriti {somma + lunghezza}");
    }
        public static void EsercizioComplessivo_Do_While_For()
        {
            Console.WriteLine($"Imposta i Tuoi Dati");
            Console.WriteLine($"Imposta il Tuo Nome");
            string Utente = (Console.ReadLine());
            Console.WriteLine($"Imposta una Password");
            string Utente2 = (Console.ReadLine());
            int ControllaRovescia = 6;
            bool accesso = false;

            do
            {
                Console.WriteLine($"Inserisci Dati di Sblocco");
                Console.Write($"Nome: ");
                string Nome = (Console.ReadLine());

                Console.Write($"Password: ");
                string Password = (Console.ReadLine());

                if(Nome == Utente && Password == Utente2)
                {
                    for(int i = ControllaRovescia; i == 0; i--)
                    {
                        Console.WriteLine($"Accesso Consentito, Ora hai 6 scelte Prima di essere Espulso dal Programma");
                        Console.WriteLine($"1.Dizionario");
                        Console.WriteLine($"2.Bestiario di D&D");
                        Console.WriteLine($"3.Notizie sul Mondo dei VideoGiochi");
                        Console.WriteLine($"4.Consigli Per la Dieta");
                        Console.WriteLine($"5.Previsioni del Tempo");
                        Console.WriteLine($"6.Andar per Funghi?");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Write($"La Lingua Italiana ha al momento ha 2 milioni se si contano tutte le possibili declinazioni e coniugazioni");
                                ControllaRovescia--;
                            break;

                            case "2":
                                Console.Write($"Il Numero di Entità all'interno del bestiario varia a seconda del manuale, nella quinta edizione conta 500 creature, nel Manuale dei Mostri del 2014 350");
                                ControllaRovescia--;
                            break;

                            case "3":
                                Console.Write($"è Stata annunciata la possibilità che lo studio di sviluppo FromSoftware potrebbe star lavorando ad un gioco a tema Pirati. Cosa? volevi più di Una notizia? Questa è la più importante di tutte FIDATI");
                                ControllaRovescia--;
                            break;

                            case "4":
                                Console.Write($"Mangia di meno e Mangia meglio, lo so sembra poco, ma è sostanzialmente quello ti direbbe un qualunque dietologo");
                                ControllaRovescia--;
                            break;

                            case "5":
                                Console.Write($"Metti la Testa fuori dalla finestra e guarda");
                                ControllaRovescia--;
                            break;

                            case "6":
                                Console.Write($"Non credo che nel tuo caso serva");
                                ControllaRovescia--;
                            break;
                        }
                        Console.WriteLine($"Tentativi rimasti {ControllaRovescia}");
                    }
                }
                else if (Nome != Utente && Password != Utente2)
                {
                    Console.WriteLine($"Accesso negato");
                    accesso = true;
                }

            }while(accesso == false);
        }
    public static void Es1pag76()
    {
        Console.WriteLine($"Inserisci il tuo Nome");
        string Nome = (Console.ReadLine());
        Console.Write($"Ciao {Nome},Cosa Posso Fare per Te?");
    }
    public static void Es2pag76()
    {
        Console.WriteLine($"inserisci un numero intero");

        if (int.TryParse(Console.ReadLine(),out int Numero))
        {
            if(Numero % 2 == 0)
            {
                Console.WriteLine($"Il numero {Numero} è Pari");
            }
            else
            {
                Console.WriteLine($"Il numero {Numero} è Dispari");
            }
        }
        else
        {
            Console.WriteLine($"Non hai inserito un dato valido");
        }
    }
    public static void Es3pag76()
    {
        Console.WriteLine($"Inserisci un Numero e un Esponente");
        Console.Write($"Numero: ");
        int Numero = int.Parse(Console.ReadLine());
        Console.Write($"Esponente: ");
        int Esponente = int.Parse(Console.ReadLine());
        Console.WriteLine($"Il risultato è {Math.Pow(Numero,Esponente)}");
    }
    public static void Es1pag113()
    {
        Console.WriteLine($"Quanti numeri desideri immettere");
        int lunghezzaArray = int.Parse(Console.ReadLine());
        int[] numeriArr = new int[lunghezzaArray];

        for(int i = 0; 1 < numeriArr.Length; i++)
        {
            Console.WriteLine($"Imposta i numeri nella quanta che hai scelto");
            numeriArr[i] = int.Parse(Console.ReadLine());
        }
        int somma = 0;
        for(int i = 0; i < numeriArr.Length; i++)
        {
            somma += numeriArr[i];
            Console.WriteLine($"la somma è {somma += numeriArr[i]}");
        }
    }
    public static void MatrixExemple()
    {
        Console.Write($"Inserisci numero righe: ");
        int nRow = int.Parse(Console.ReadLine());
        Console.WriteLine($"Inserisci numero colonne: ");
        int nColumn = int.Parse(Console.ReadLine());
        
        int[,] matrice = new int[nRow, nColumn];

        for(int r=0; r < matrice.GetLength(0); r++)
        {
            for(int c=0; c < matrice.GetLength(1); c++)
            {
                matrice[r,c] = (c + r+ 1) * 10;
                Console.WriteLine($"Matrice [{r}, {c}] è uguale a {matrice[r,c]}");
            }
            
        }
    }
    public static void MainDiagonal()
    {
        Console.Write($"Inserisci numero delle dimensioni: ");
        int dimensions = int.Parse(Console.ReadLine());
    
        int[,] matrice = new int[dimensions, dimensions];

        Random rnd = new Random();
        for(int r=0; r < matrice.GetLength(0); r++)
        {
            for(int c=0; c < matrice.GetLength(0); c++)
            {
                matrice[r, c] = rnd.Next(1, 11);
                Console.Write($"{matrice[r, c]}  ");
                
            }
            Console.WriteLine($"");
            
        }
        
        int sumDiag1 = 0;
        for(int r=0; r < matrice.GetLength(0); r++)
        {
            for(int c=0; c < matrice.GetLength(0); c++)
            {
                if(c == r)
                {
                    sumDiag1 += matrice[r,c];
                    Console.WriteLine($"Elemento indiagonale di r{r} e c{c} è {matrice[r,c]}");
                    
                }
            }
            
        }
        Console.WriteLine($"\nLa somma dell adiagonale principale è {sumDiag1}\n");

        int sumDiag2 = 0;

        for(int r =0 ; r < dimensions; r++)
        {
            for(int c =0 ; c < dimensions; c++)
            {
                if(r + c == dimensions - 1)
                {
                    sumDiag2 += matrice[r, c];
                    Console.WriteLine($"Elemento in diagonale2 di r{r} e c{c} è {matrice[r,c]}");
                }
            }
            
        }
        Console.WriteLine($"\nLa somma dell adiagonale principale è {sumDiag2}\n");
    }
    public static void Es1Pag114()
    {
        Console.Write($"Inserisci il numero delle Colonne: ");
        int nColonne = int.Parse(Console.ReadLine());
        Console.Write($"Inserisci il numero di Righe: ");
        int nRighe = int.Parse(Console.ReadLine());

        int[,] Matrice = new int[nColonne, nRighe];

        int sumMat = 0;
        for(int r = 0; r < Matrice.GetLength(0); r++)
        {
            for(int c = 0; c < Matrice.GetLength(1); c++)
            {
                Matrice[r, c] = (c + r + 1) * 10;
                sumMat += Matrice[r, c];
                Console.WriteLine($"\nMatrice[{r},{c}] è uguale a{Matrice[r,c]}\n");
                
            }
        }
        Console.WriteLine($"\nLa somma di tutti i valoro è {sumMat}\n");
    }

    public static void Es2Pag114()
    {
        //Sono un fallito
    }

    public static void Es3Pag114()
    {
        //Sono un MEGA fallito
    }
    }