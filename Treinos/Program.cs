class Inverter  //criação da classe Inverter.
{
    public int numero1, numero2;    //teremos 2 variáveis do tipo int.
    public Inverter(int num1, int num2) //o construtor vai receber 2 parametros int e os colocar nas variáveis.
    {
        numero1 = num1;
        numero2 = num2;
    }

    public static Inverter operator -(Inverter inv) //sobrecarga de operador unário de negação (-).
    {
        inv.numero1 = -inv.numero1; //o numero recebido terá o sinal trocado
        inv.numero2 = -inv.numero2; //o numero recebido terá o sinal trocado
        return inv;
    }
    
    public void Print() //série de funções para mostrar os valores com sinal trocado...
    {
        Console.WriteLine();
        Console.WriteLine("Número 1: " + numero1);
        Console.WriteLine("Número 2: " + numero2);
    }
    public void PrintNegativos()
    {
        Console.WriteLine();
        Console.WriteLine("Seus números com sinais invertidos:");   //tira o sinal se os dois numeros forem 0
        Console.WriteLine("Número 1: " + Math.Abs(numero1));
        Console.WriteLine("Número 2: " + Math.Abs(numero2));
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
            troca.Print();
        }
        else if (usernum1 == 0 || usernum2 == 0)
        {
            troca.Print();
        }
        else
        {
            troca.Print();
        }
    }
}