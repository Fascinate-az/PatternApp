public class AppMain
{
    GetSetting _setting = new GetSetting();
    Menu _menu = new Menu();
    Msg _msg = new Msg();
    VerificaInput _verificaInput = new VerificaInput();
    CloseApp _closeApp = new CloseApp();
    
    public void Run()
    {
        
        while (true)
        {
            int dimensione = _setting.GetDimension();
            char symbol = _setting.GetSymbol();
            _menu.ShowMenu(dimensione, symbol);
            _msg.TornareAlMenuPrincipale();
            string scelta = _verificaInput.LeggiInput();

            if (scelta.IsWhiteSpace())
            {
                _closeApp.Exit();
                break;
            }


        }
        
        
    }
}

public class GetSetting
{
    private Msg _messaggi = new Msg();
    private VerificaInput verificaInput = new VerificaInput();
    public int _dimensione { get; private set; }

    

    public int GetDimension()
    {
        _messaggi.AskDimension();

        while (true)
        {
            (bool isValid,string verificaInput,int dimensione) valore = verificaInput.IntTryParse();

            if (valore.dimensione < 3)
            {
                _messaggi.DimensioneInferiore();
            }
            else if(valore.isValid == false)
            {
                _messaggi.DimensioneNonValida();
            }
            else
            {
                
                return (valore.dimensione);
            }
            
        }
    }
    

    public char GetSymbol()
    {
        _messaggi.GetSymbol();

        (bool isValid, char symbol) input = verificaInput.CharTryParse();

        while (!input.isValid)
        {
            _messaggi.SimboloNonValido();
            input = verificaInput.CharTryParse();
        }

        Console.WriteLine($"il simbolo scelto è {input.symbol}");

        return  input.symbol;
    }
    
}

public class Menu
{
    Msg _messaggi = new Msg();
    VerificaInput _verificaInput = new VerificaInput();
    Pattern _pattern = new Pattern();
    CloseApp _closeApp = new CloseApp();
    
    
    
    public void ShowMenu(int dimensione , char symbol)
    {
        
        bool continua = true;
        
        
        while (continua)
        {
            _messaggi.MenuPattern();
            (bool isValid,string input,int number)scelta = _verificaInput.IntTryParse();

            if (scelta.input.IsWhiteSpace())
            {
                continua = false;
                _closeApp.Exit();
            }
            
            switch (scelta.number)
            {
                case 1:
                    _pattern.Triangolo(dimensione,symbol,scelta.number);
                    continua = false;
                    break;
                case 2:
                    _pattern.Triangolo(dimensione,symbol,scelta.number);
                    continua = false;
                    break;
                case 3:
                    _pattern.Triangolo(dimensione,symbol,scelta.number);
                    continua = false;
                    break;
                case 4:
                    _pattern.Piramide(dimensione,symbol,scelta.number);
                    continua = false;
                    break;
                case 5:
                    _pattern.Piramide(dimensione,symbol,scelta.number);
                    continua = false;
                    break;
                case 6:
                    _pattern.Rombo(dimensione,symbol,scelta.number);
                    continua = false;
                    break;
                case 7:
                    _pattern.Quadrato_Rettangolo(dimensione,symbol,scelta.number);
                    continua = false;
                    break;
                case 8 :
                    _pattern.Quadrato_Rettangolo(dimensione,symbol,scelta.number);
                    continua = false;
                    break;
                default:
                    _messaggi.ErroreNellaScelta();
                    break;
            }
        }
    }
}


class CloseApp
{
    Msg _messaggi = new Msg();

    public void Exit()
    {
        _messaggi.UscitaInCorso();
        Environment.Exit(0);
    }
}
