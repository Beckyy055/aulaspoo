using System.Globalization;
using poo7;


Console.WriteLine("Bem vindo a calculadora! Digite 1 se deseja somar ou 2 se deseja subtrair");

string input  = Console.ReadLine();
int valor1;
int valor2;

switch (input)
{
    case "1":
        Console.WriteLine("Digite o primeiro valor: ");
        valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        valor2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"O valor da soma é {Calculadora.Soma(valor1 , valor2)}");
        break;

    case "2":
        Console.WriteLine("Digite o primeiro valor: ");
        valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        valor2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"O valor da soma é {Calculadora.Subtração(valor1, valor2)}");
        break;

}