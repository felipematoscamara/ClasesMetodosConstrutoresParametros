/*Objetivo: Crie uma classe Computador e implemente um menu simples para o usuário interagir.
Atributos: Modelo(string), Processador(string), MemoriaRAM(int), Armazenamento(int), 
SistemaOperacional(string).

Construtor: Utilize um construtor que inicialize os atributos usando this.

Métodos:
a) ExibirInformacoes(): Exiba todas as informações do computador.
b) Ligar(string modelo): Exiba a mensagem "Ligando o computador modelo {modelo}".

Desafio Adicional:
No método Main(), crie pelo menos dois objetos do tipo Computador e, utilizando uma 
estrutura condicional switch, implemente um menu que permita ao usuário escolher entre:
1: Exibir informações do computador
2: Ligar o computador
3: Sair
Utilize uma estrutura de repetição (while ou do-while) para que o menu continue até que 
o usuário escolha sair.*/

using System.Runtime.CompilerServices;

Computador computador1 = new("MacBook Air", "Apple M1", 8, 512, "macOS Sonoma");
Computador computador2 = new("Acer Nitro 5", "Intel Core i7-12700H", 16, 1000, "Windows 10 Pro");

while (true)
{
    Console.WriteLine("## Cadastro de Computadores Com Menu ##\n");
    Console.WriteLine("O'que deseja fazer?");
    Console.WriteLine("1: Exibir informações do computador");
    Console.WriteLine("2: Ligar o computador");
    Console.WriteLine("3: Sair");

    var opcao = int.Parse(Console.ReadLine());
    
    switch (opcao)
    {
        case 1:
            Console.WriteLine();
            computador1.ExibirInformacoes();
            Console.WriteLine();
            computador2.ExibirInformacoes();
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine();
            computador1.Ligar("MacBook Air");
            computador2.Ligar("Acer Nitro 5");
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine();
            Console.WriteLine("Saindo...");
            Console.WriteLine();
            return;
        default:
            Console.WriteLine();
            Console.WriteLine("Opção Inválida, Tente Novamente!");
            Console.WriteLine();
            break;
    }
}

public class Computador
{
    string Modelo;
    string Processador;
    int MemoriaRAM;
    int Armazenamento;
    string SistemaOperacional;

    public Computador(string modelo, string processador, int memoriaRAM, int armazenamento, string sistemaOperacional)
    {
        this.Modelo = modelo;
        this.Processador = processador;
        this.MemoriaRAM = memoriaRAM;
        this.Armazenamento = armazenamento;
        this.SistemaOperacional = sistemaOperacional;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Processador: {Processador}");
        Console.WriteLine($"MemoriaRAM: {MemoriaRAM}");
        Console.WriteLine($"Armazenamento: {Armazenamento}");
        
    }

    public void Ligar(string modelo)
    {
        Console.WriteLine($"Ligando meu computador modelo {modelo}");
    }
}