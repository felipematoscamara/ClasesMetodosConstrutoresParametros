/*Crie uma classe Computador com os seguintes atributos: string Modelo, string Processador,
int MemoriaRAM, int Armazenamento, string SistemaOperacional
a) Crie um construtor para inicializar todos os atributos.
b) Crie um método chamado ExibirInformacoes() que exiba todos os dados no console.
c) Crie um método chamado Ligar(string modelo) que exibe: "Ligando o computador modelo {modelo}"
d) No ExibirInformacoes(), chame o método Ligar() passando o modelo como argumento.
e) Crie dois objetos com valores diferentes e exiba os dados no console*/
Console.WriteLine("## Classe Computador ##\n");

Computador computador = new("MacBook Air", "Apple M1", 8, 512, "macOS Sonoma");
computador.ExibirInformacoes();

Computador computador2 = new("Acer Nitro 5", "Intel Core i7-12700H", 16, 1000, "Windows 10 Pro");
computador2.ExibirInformacoes();

Console.ReadKey();
public class Computador
{
    public string? Modelo;
    public string? Processador;
    public int MemoriaRAM;
    public int Armazenamento;
    public string? SistemaOperacional;

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
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Processador: " + Processador);
        Console.WriteLine("MemóriaRAM: " + MemoriaRAM);
        Console.WriteLine("Armazenamento: " + Armazenamento);
        Console.WriteLine("Sistema Operacional: " + SistemaOperacional);
        Ligar(this.Modelo);
        Console.WriteLine();
    }
     
    public void Ligar(string modelo)
    {
        Console.WriteLine($"Ligando o computador modelo {modelo}");
    }
}