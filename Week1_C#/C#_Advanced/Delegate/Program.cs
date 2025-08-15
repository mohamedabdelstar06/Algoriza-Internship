namespace Delegate;

public  class Program
{
    public delegate int CalculateDelegate(int num1 , int num2);
    static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 3;

        Calculate(num1, num2, Add);
        Calculate(num1, num2, Subtracte);
        Calculate(num1, num2, delegate (int num1, int num2) { return num1 * num2; });
        Calculate(num1, num2, (x,y  ) => x % y );

    }
    static void Calculate(int num1 , int num2, CalculateDelegate dlg)
    {
        int result = dlg(num1, num2);
        Console.WriteLine($"Result = {result}");

    }
    static int  Add(int num1, int num2) 
    {
        Console.WriteLine("Subtracte");
        return num1 + num2;
    }
    static int Subtracte(int num1, int num2)
    {
        Console.WriteLine("Subtracte");
        return num1 - num2;
    }
    static int Multiply(int num1, int num2)
    {
        Console.WriteLine("Multiply");
        return num1 * num2;
    }
    static int Divide(int num1, int num2)
    {
        Console.WriteLine("Divide");
        return num1 / num2;
    }
    
}
