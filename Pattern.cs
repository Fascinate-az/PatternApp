public class Pattern
{
    Msg messaggi = new Msg();
    public void Triangolo(int dimensione,char simbolo,int scelta)
    {
        messaggi.LineeDivisorie();
        if (scelta == 1)
        {
            for (int i = 0; i < dimensione; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{simbolo}");
                }

                Console.WriteLine();
            }
        }
        else if (scelta == 2)
        {
            for (int i = 0; i < dimensione; i++)
            {
                for (int j = 0; j < dimensione-i; j++)
                {
                    Console.Write($"{simbolo}");
                }
                Console.WriteLine();
            }
        }
        else if (scelta == 3)
        {
            for (int i = 0; i < dimensione*2-1; i++)
            {
                if (i < dimensione)
                {
                    for (int j = 0; j <= i ; j++)
                    {
                        Console.Write($"{simbolo}");
                    }
                }
                else
                {
                    for (int j = 0; j < dimensione*2-i-1; j++)
                    {
                        Console.Write($"{simbolo}");
                    }
                }

                Console.WriteLine();
            }
        }
        
        messaggi.LineeDivisorie();
    }

    public void Piramide(int dimensione, char simbolo, int scelta)
    {
        messaggi.LineeDivisorie();
        
        if (scelta == 4)
        {
            for (int i = 0; i < dimensione; i++)
            {
                for (int j = 0; j < dimensione-i-1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <=i*2; j++)
                {
                    Console.Write($"{simbolo}");
                }

                Console.WriteLine();
            }
        }
        else if (scelta == 5)
        {
            for (int i = 0; i < dimensione; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($" ");
                }

                for (int j = 0; j < (dimensione*2-1)-i*2 ; j++)
                {
                    Console.Write($"{simbolo}");
                }

                Console.WriteLine();
            }
        }
        
        messaggi.LineeDivisorie();
    }

    public void Rombo(int dimensione, char simbolo, int scelta)
    {
        messaggi.LineeDivisorie();
        int cicloInverso = 2;
        
        for (int i = 0; i < dimensione*2-1; i++)
        {
            if (i < dimensione)
            {
                for (int j = 0; j < (dimensione-1)-i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i*2; j++)
                {
                    Console.Write($"{simbolo}");
                }
            }
            else
            {
                
                for (int j = 0; j < (i-dimensione)+1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < (dimensione*2-1)-cicloInverso; j++)
                {
                    Console.Write($"{simbolo}");
                    
                }
                cicloInverso+=2;
            }

            Console.WriteLine();
        }
        messaggi.LineeDivisorie();
    }

    public void Quadrato_Rettangolo(int dimensione, char simbolo, int scelta)
    {
        messaggi.LineeDivisorie();
        if (scelta == 7)
        {
            for (int i = 0; i < dimensione; i++)
            {
                for (int j = 0; j < dimensione; j++)
                {
                    Console.Write($"{simbolo} ");
                }
                Console.WriteLine();
            } 
        }

        if (scelta == 8)
        {
            for (int i = 0; i < dimensione; i++)
            {
                for (int j = 0; j < dimensione*2; j++)
                {
                    Console.Write($"{simbolo} ");
                }
                Console.WriteLine();
            }
        }
       
        
        messaggi.LineeDivisorie();
    }
}
