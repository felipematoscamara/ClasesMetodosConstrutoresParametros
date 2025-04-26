/*Crie uma classe chamada Produto com um método AtualizarPreco:

Um método recebe o preço original por valor e retorna o preço com 10% de acréscimo.

O outro recebe o preço original por referência e atualiza com 20% de acréscimo.

Mostre os valores antes e depois da chamada*/

using System.Numerics;

Console.WriteLine("## Atualizar o Preço do Produto ##");

double preco = 100;
Console.WriteLine("\nPreço original: " + preco);

Produto produto = new();
var preco1 = produto.AtualizarPreco(preco);
var preco2 = produto.AtualizarPreco(ref preco);

Console.WriteLine("\nO preço com acréssimo de 10%: " + preco1);
Console.WriteLine("\nO preco com acréssimo de 20%: " + preco2);

Console.ReadKey();

public class Produto
{
    public double AtualizarPreco(double preco)
    {
        preco += (10.0 / 100) * preco;
        return preco;
    }

    public double AtualizarPreco(ref double preco)
    {
        preco += (20.0 / 100) * preco;
        return preco;
    }
}
