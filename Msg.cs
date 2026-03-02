public class Msg
{
    public void AskDimension()
    {
        Console.WriteLine("Inserire la dimensione del pattern (maggiore o uguale a 3):");
    }

    public void DimensioneInferiore()
    {
        Console.WriteLine("La dimensione minima deve essere 3.");
    }

    public void DimensioneNonValida()
    {
        Console.WriteLine("Inserire un valore numerico uguale o maggiore di 3.");
    }

    public void GetSymbol()
    {
        Console.WriteLine("Inserire il simbolo per disegnare il pattern.Deve essere un unico carattere.");
    }

    public void SimboloNonValido()
    {
        Console.WriteLine("Il simbolo deve essere un unico carattere,riprovare:");
    }

    public void MenuPattern()
    {
        Console.WriteLine("Digitare il numero del pattern:\n1.Triangolo.\n2.Triangolo Inverso.\n3.Doppio Triangolo.\n4.Piramide.\n5.Piramide Inversa.\n6.Rombo.\n7.Quadrato\n8.Rettangolo\nSpazio vuoto Per uscire.");
    }

    public void ErroreNellaScelta()
    {
        Console.WriteLine("Errore, scegliere una delle opzioni valide:");
    }

    public void UscitaInCorso()
    {
        Console.WriteLine("Uscita in corso ....");
    }

    public void LineeDivisorie()
    {
        Console.WriteLine();
        Console.WriteLine("---------------------------");
        Console.WriteLine();
    }

    public void TornareAlMenuPrincipale()
    {
        Console.WriteLine("Premere spazio vuoto per uscire, o qualsiasi altro tasto per tornare al menu principale");
    }
}
