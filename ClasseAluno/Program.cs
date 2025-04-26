/*Crie uma classe Aluno com os seguintes atributos: string Nome, int Idade, string Curso,
double MediaFinal.
a) Crie um construtor para definir todos os atributos.
b) Crie um método chamado Apresentar() que exibe: Aluno: [nome], Curso: [curso], Média: [media]
c) Crie um método VerificarAprovacao(double media) que exibe:
“Aprovado” se a média for maior ou igual a 7 “Reprovado” caso contrário
d) No método Apresentar(), chame VerificarAprovacao() passando o atributo MediaFinal.*/
using System.Runtime.CompilerServices;

Console.WriteLine("## Classe Aluno ##\n");

Aluno aluno = new("Felipe", 21, "Ciência da Computação", 8.9);
aluno.Apresentar();

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
        Console.WriteLine($"Aluno: [{Nome}], Curso: [{Curso}], Média: [{MediaFinal}]");
        VerificarAprovacao();
    }

    public void VerificarAprovacao()
    {
        if(MediaFinal < 7) 
            Console.WriteLine("Aluno Reprovado!");
        else
            Console.WriteLine("Aluno Aprovado!");
    }
}