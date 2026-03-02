public class VerificaInput
 {
    public (bool,string,int) IntTryParse()
    {
        string input;
        bool isValue = int.TryParse( input = Console.ReadLine(), out int output);
        
        return (isValue,input,output);
    }
    
    public (bool,char) CharTryParse()
    {
        bool isValue = char.TryParse(Console.ReadLine(), out char symbol);
        
        return (isValue, symbol);
       
    }

    public string LeggiInput()
    {
        string input = Console.ReadLine();
        return input;
    }
    
}
