/*Objetivo: Pratique métodos com parâmetros e estruturas condicionais criando uma 
calculadora simples.

Classe: Crie uma classe Calculadora.

Métodos:
a) Somar(double a, double b)
b) Subtrair(double a, double b)
c) Multiplicar(double a, double b)
d) Dividir(double a, double b): Use uma estrutura condicional para verificar se b é 
diferente de zero. Se for zero, exiba uma mensagem de erro; caso contrário, exiba o resultado
da divisão.

Desafio Adicional:
No método Main(), peça ao usuário que digite dois números e escolha a operação (por exemplo, 
digitando 1 para soma, 2 para subtração etc.). Utilize uma estrutura switch para chamar 
o método adequado e, se desejar, um laço de repetição para permitir várias operações até
que o usuário decida sair.*/

Console.WriteLine("## Calculadora ##\n");

Console.Write("Digite o Primeiro Numero: ");
var a = double.Parse(Console.ReadLine());

Console.Write("Digite o Segundo Numero: ");
var b = double.Parse(Console.ReadLine());


Console.WriteLine("Escolha o Operador:");
Console.WriteLine("1 - Somar");
Console.WriteLine("2 - Subtrair");
Console.WriteLine("3 - Dividir");
Console.WriteLine("4 - Multiplicar");
var operador = int.Parse(Console.ReadLine());

if(operador == 4 && b == 0)
{
    Console.WriteLine("ERRO! não exite divisão por zero, tente novamente...");
    return;
}

Calculadora calculator = new();

switch (operador)
{
    case 1:
        calculator.Somar(a, b);
        break;
    case 2:
        calculator.Subtrair(a, b);
        break;
    case 3:
        calculator.Dividir(a, b);
        break;
    case 4:
        calculator.Multiplicar(a, b);
        break;
    default:
        Console.WriteLine("Opção Inválida! Tente Novamente!");
        break;
}

public class Calculadora
{
    public void Somar(double a, double b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    public void Subtrair(double a, double b)
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }

    public void Dividir(double a, double b)
    {
        Console.WriteLine($"{a} ÷ {b} = {a / b}");
    }

    public void Multiplicar(double a, double b)
    {
        Console.WriteLine($"{a} x {b} = {a *b}");
    }
}