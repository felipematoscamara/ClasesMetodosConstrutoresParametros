/* Crie um programa em C# que solicite ao usuário o nome de um aluno e as três notas que ele obteve 
 * durante o semestre. Em seguida, calcule a média final do aluno. O programa deve usar um método 
 * chamado CalcularMedia que receba as três notas como parâmetros e utilize o modificador out para 
 * retornar a média final e uma mensagem indicando a situação do aluno:

Média abaixo de 5: Reprovado

Média entre 5 (inclusive) e 6.9: Recuperação

Média 7 ou mais: Aprovado

No final, exiba o nome do aluno, a média final e a situação dele.*/
using System.Transactions;

Console.WriteLine("## Cálculo de Média Final de Aluno ##\n");

Console.Write("Qual o nome do aluno? ");
string aluno = Console.ReadLine();

Console.Write("\nDigite a n1: ");
double n1 = double.Parse(Console.ReadLine().Replace(".",","));

Console.Write("Digite a n2: ");
double n2 = double.Parse(Console.ReadLine().Replace(".",","));

Console.Write("Digite a n3: ");
double n3 = double.Parse(Console.ReadLine().Replace(".",","));

string situacao;
double mediaFinal;
Media mediaAluno = new();  
mediaAluno.CalcularMedia(n1, n2, n3, out mediaFinal, out situacao);

Console.WriteLine("\nAluno: "+ aluno);
Console.WriteLine($"Média Final: {mediaFinal:f1}");
Console.WriteLine("Situação: "+ situacao);

Console.ReadKey();
public class Media
{
    public double CalcularMedia(double n1, double n2, double n3, out double mediaFinal, out string situacao)
    {
        mediaFinal = (n1 + n2 + n3) / 3;

        if (mediaFinal < 5)
            situacao = "Aluno Reprovado";
        else if (mediaFinal < 7)
            situacao = "Aluno de Recuperação";
        else
            situacao = "Aluno Aprovado";

        return mediaFinal;
    }
}