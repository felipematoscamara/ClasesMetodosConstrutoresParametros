/*Crie uma classe chamada Saude com um método chamado CalcularIMC.

O que o método deve fazer:
Receber dois parâmetros: peso (double) e altura (double).
Calcular o IMC (Índice de Massa Corporal) usando a fórmula: IMC = peso / (altura * altura)
O método deve retornar o valor do IMC (double).
Também deve usar um parâmetro out para devolver uma mensagem de classificação de acordo com a tabela 
abaixo:

IMC	                Classificação
Menor que 18.5	    Abaixo do peso
Entre 18.5 e 24.9	Peso normal
Entre 25.0 e 29.9	Sobrepeso
Entre 30.0 e 34.9	Obesidade grau I
Entre 35.0 e 39.9	Obesidade grau II
40.0 ou mais	    Obesidade grau III

O que você precisa fazer:
Criar a classe Saude.
Criar o método CalcularIMC com o parâmetro out.
Fazer a chamada ao método a partir do Main, informando os dados de uma pessoa.
Exibir o IMC e a classificação no console.
Se quiser um desafio extra, pode permitir a entrada de dados via Console.ReadLine() também 😎*/

using System.Reflection.PortableExecutable;
using System.Xml.Serialization;

Console.WriteLine("## Calculo de IMC e classificação ##\n");

Console.Write("Digite o seu peso: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a sua altura: ");
double altura = Convert.ToDouble(Console.ReadLine().Replace(".",","));

double imc;
string classificacao;

Saude saude = new();
saude.CalcularIMC(peso, altura, out imc, out classificacao);

Console.WriteLine($"\nSeu IMC está em {imc:f1}");
Console.WriteLine($"Você está em {classificacao}");

Console.ReadKey();

public class Saude
{
    public void CalcularIMC(double peso, double altura, out double imc, out string classificacao)
    {
        imc = peso / (altura * altura);

        if (imc < 18.5)
            classificacao = "Abaixo do peso";
        else if (imc < 24.9)
            classificacao = "Peso normal";
        else if (imc < 29.9)
            classificacao = "Sobrepeso";
        else if (imc < 34.9)
            classificacao = "Obesidade grau I";
        else if (imc < 39.9)
            classificacao = "Obesidade grau II";
        else
            classificacao = "Obesidade grau III";

    }
}