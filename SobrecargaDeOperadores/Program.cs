using System.Security.Cryptography;

class Calculator    //classe calculadora (que vai apenas inverter sinais de numeros)
{
    public int numero1, numero2; //duas variaveis do tipo inteiro
    public Calculator(int num1, int num2) //construtor da classe recebe dois inteiros como parametros
    {
        numero1 = num1; //atribui os parametros aos valores das variaveis
        numero2 = num2;
    }
    public static Calculator operator -(Calculator cl) //sobrecarregando o - para trabalhar com objetos da classe Calculator. Neste caso, cl é o objeto da classe Calculator.
    {
        cl.numero1 = -cl.numero1;   //pega o objeto cl e inverte o sinal
        cl.numero2 = -cl.numero2;
        return cl; //retorna o objeto cl modiicado
    }
    public void Print() //função para mostrar os valores
    {
        Console.WriteLine("Número 1 = " + numero1);
        Console.WriteLine("Número 2 = " + numero2);
    }
}

class Program
{
    static void Main(string[] args) 
    {
        Calculator calc = new Calculator(7, -2);    //instanciei um objeto da classe Calculator
        calc.Print(); //será exibido o valor antes da inversão
        Console.WriteLine(); //linha em branco
        calc = -calc; //inverte o sinal dos valores
        calc.Print();   //mostra os valores, que agora estão com sinal invertido.
    }
}