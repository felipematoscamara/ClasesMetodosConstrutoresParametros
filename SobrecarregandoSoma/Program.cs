/*Crie dois métodos Somar:
Um que soma dois valores inteiros (int a, int b) passados por valor.
Outro que soma três valores inteiros passados por valor.
Use sobrecarga para diferenciar os dois métodos. Mostre o uso de ambos no Main.*/

Console.WriteLine("## Sobrecarrengando Soma ##");

Classe classe = new();
int a = classe.Somar(10, 20);
int b = classe.Somar(10, 20, 30);

Console.WriteLine(a);
Console.WriteLine(b);

Console.ReadKey();

public class Classe
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }
}