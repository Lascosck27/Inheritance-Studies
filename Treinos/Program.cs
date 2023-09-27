class Inverter
{
    public int numero1, numero2;
    public Inverter(int num1, int num2)
    {
        numero1 = num1;
        numero2 = num2;
    }

    public static Inverter operator -(Inverter inv)
    {
        inv.numero1 = -inv.numero1;
        inv.numero2 = -inv.numero2;
        return inv;
    }
    
    public void Print()
    {
        Console.WriteLine();
        Console.WriteLine("Número 1: " + numero1);
        Console.WriteLine("Número 2: " + numero2);
    }
    public void PrintNegativos()
    {
        Console.WriteLine();
        Console.WriteLine("Seus números com sinais invertidos:");
        Console.WriteLine("Número 1: " + Math.Abs(numero1));
        Console.WriteLine("Número 2: " + Math.Abs(numero2));
    }
    public void PrintUm()
    {
        Console.WriteLine();
        Console.WriteLine("Seus números com sinais invertidos:");
        Console.WriteLine("Número 1: " + Math.Abs(numero1));
        Console.WriteLine("Número 2: " + numero2);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        int usernum1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite mais um número: ");
        int usernum2 = int.Parse(Console.ReadLine());

        Inverter troca = new Inverter(usernum1, usernum2);
        troca = -troca;

        if (usernum1 == 0 && usernum2 == 0) 
        { 
            troca.PrintNegativos();
        }
        else if (usernum1 == 0 || usernum2 == 0)
        {
            troca.PrintUm();
        }
        else
        {
            troca.Print();
        }
    }
}