/*Crie uma classe chamada Bicicleta com os seguintes atributos: modelo (string), marca (string), ano (int), aro (int) e cor (string)

Crie um construtor que receba todos os atributos como parâmetros e use this para atribuí-los.

Crie um método chamado MostrarDados() que exiba todos os dados da bicicleta no console.

Crie um método chamado Pedalar(string marca) que exiba a mensagem: "Pedalando com a minha bicicleta {marca}"

Crie dois objetos da classe Bicicleta, passe os valores diretamente no construtor.

Chame o método MostrarDados() e o método Pedalar() para cada bicicleta.*/

using System.Diagnostics;
Console.WriteLine("## Cadastro de Bicicletas ##");

Bicicleta bicicleta1 = new("Speed 3000", "Caloi", 2021, 29, "Vermelha");
bicicleta1.MostrarDados();

Bicicleta bicicleta2 = new("Trail Blazer", "Oggi", 2023, 27, "Prata");
bicicleta2.MostrarDados();

public class Bicicleta
{
    public string? Modelo;
    public string? Marca;
    public int Ano;
    public int Aro;
    public string? Cor;

    public Bicicleta(string? modelo, string? marca, int ano, int aro, string cor)
    {
        this.Modelo = modelo;
        this.Marca = marca;
        this.Ano = ano;
        this.Aro = aro;
        this.Cor = cor; 
    }

    public void MostrarDados()
    {
        Console.WriteLine("--Dados Bicicleta--");
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Aro: " + Aro);
        Console.WriteLine("Cor: " + Cor);
        Pedalar(this.Marca);
        Console.WriteLine();
    }

    public void Pedalar(string marca)
    {
        Console.WriteLine($"Pedalando com minha bicicleta {marca}");
    }
} 