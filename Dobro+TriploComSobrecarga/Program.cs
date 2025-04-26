/*Crie uma classe chamada Operacoes.
Implemente dois métodos chamados Multiplicar:

Um que recebe um número int por valor e retorna o dobro do número.

Outro que recebe um número int por referência e triplica seu valor.

No Main, declare uma variável, chame os dois métodos e exiba os resultados.*/

Console.WriteLine("## Dobro e Triplo com Sobrecarga ##\n");

int numero = 10;

Operacoes operacoes = new();
var dobro = operacoes.Multiplicar(numero);
var triplo = operacoes.Multiplicar(ref numero);

Console.WriteLine();

Console.WriteLine("Dobro: "+dobro);
Console.WriteLine("Triplo: "+triplo);


public class Operacoes
{
    public int Multiplicar(int numero)
    {
        return numero *= 2;
    }

    public int Multiplicar(ref int numero)
    {
        return numero *= 3;
    }
}
