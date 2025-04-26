/*Objetivo: Crie uma classe Contato para praticar o cadastro e a busca de informações de 
contatos, sem o uso de arrays ou listas.

Atributos: Nome (string), Telefone (string), Email (string)

Construtor: Utilize um construtor que inicialize os atributos com this.

Métodos: a) ExibirContato(): Exiba os dados do contato.

Desafio Adicional:
Crie dois ou três objetos do tipo Contato individualmente. Em seguida, peça ao usuário 
para digitar o nome de um contato para buscar. Utilize estruturas condicionais (if/else)
para comparar o nome digitado com o atributo Nome de cada objeto e, se houver correspondência,
exiba as informações do contato.*/

Console.WriteLine("## Gerenciador de Contatos Simplificado ##\n");

Contato contato = new("Bruno", "88 98765-6754", "bruno123@gmail.com");
Contato contato2 = new("Pamela", "45 98865-4221", "Pam5643@gmail.com");

Console.Write("Com quem voçe gostaria de falar? ");
var nome = Console.ReadLine().ToUpper();

if (nome == contato.Nome.ToUpper())
{
    Console.WriteLine("Contato encontrado:");
    contato.ExibirContato();
}
else if (nome == contato2.Nome.ToUpper())
{
    Console.WriteLine("Contato encontrado:");
    contato2.ExibirContato();
}
else
    Console.WriteLine("Contato não encontrado.");

Console.ReadKey();
public class Contato
{
    public string Nome;
    string Telefone;
    string Email;

    public Contato(string nome, string telefone, string email)
    {
        this.Nome = nome;
        this.Telefone = telefone;
        this.Email = email;
    }

    public void ExibirContato()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Telefone: {Telefone}");
        Console.WriteLine($"E-mail: {Email}");
        Console.WriteLine();
    }

}

