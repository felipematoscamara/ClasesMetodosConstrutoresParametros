/*Objetivo: Crie uma classe Aluno que armazene os dados do aluno e verifique se ele foi 
aprovado. 

Atributos: Nome (string), Idade (int), Curso (string), MediaFinal (double).

Construtor: Crie um construtor para inicializar todos os atributos usando this.

Métodos:
a) Apresentar(): Exiba os dados do aluno (usando interpolação, se preferir).
b) VerificarAprovacao(): Se MediaFinal for maior ou igual a 7, exiba "Aluno Aprovado!".
Caso contrário, exiba "Aluno Reprovado!".

Desafio Adicional: Crie individualmente três objetos (por exemplo, aluno1, aluno2 e aluno3) 
com valores diferentes. Em seguida, use uma estrutura de repetição (como um for que itere 
de 1 a 3, ou mesmo utilizar três chamadas separadas) para chamar o método Apresentar() 
em cada objeto.*/

using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

Console.WriteLine("## Classe Aluno com Laço de Repetição ##\n");

Aluno aluno = new("Felipe", 21, "Ciência da Computação", 8.8);
Aluno aluno2 = new("Bruno", 18, "Economia", 6.9);
Aluno aluno3 = new("Ana", 23, "Direito", 9.0);

for(int i = 1; i <= 3; i++)
{
    if(i == 1)
    {
        aluno.Apresentar();
        Console.WriteLine($"Situação: {aluno.VerificarAprovacao()}");
        Console.WriteLine("---------------\n");
    }
    else if(i == 2)
    {
        aluno2.Apresentar();
        Console.WriteLine($"Situação: {aluno2.VerificarAprovacao()}");
        Console.WriteLine("---------------\n");
    }
    else
    {
        aluno3.Apresentar();
        Console.WriteLine($"Situação: {aluno3.VerificarAprovacao()}");
        Console.WriteLine("---------------\n");
    }
}

Console.ReadKey();

public class Aluno
{
    string Nome;
    int Idade;
    string Curso;
    double MediaFinal;

    public Aluno(string nome, int idade, string curso, double mediaFinal)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Curso = curso;
        this.MediaFinal = mediaFinal;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine($"Media Final: {MediaFinal}");
    }

    public string VerificarAprovacao()
    {
        if (MediaFinal < 7)
            return "Reprovado";
        else
            return "Aprovado";
    }

}