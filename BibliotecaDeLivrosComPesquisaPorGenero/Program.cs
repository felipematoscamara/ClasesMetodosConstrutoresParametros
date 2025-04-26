/*Objetivo: Desenvolva uma classe Livro e implemente métodos para exibir e pesquisar 
livros por gênero.

Atributos: Titulo(string), Autor(string), AnoPublicacao(int), Genero(string)

Construtor: Crie um construtor que inicialize os atributos (utilizando this).

Métodos:
a) Detalhes(): Exiba as informações do livro.
b) Ler(): Exiba a mensagem "Lendo o livro {Titulo}...".

Desafio Adicional:
Crie três objetos do tipo Livro individualmente. Em seguida, peça ao usuário que digite 
um gênero (por exemplo, usando Console.ReadLine()) e, utilizando estruturas condicionais 
(if/else), compare o gênero informado com o atributo Genero de cada objeto. Se houver 
correspondência, chame o método Detalhes() para exibir as informações do livro.*/

Console.WriteLine("## Biblioteca de Livros com Pesquisa ##");

Livro livro1 = new("Frankenstein", "Mary Shelley", 1818, "Terror");
Livro livro2 = new("O Senhor dos Aneis", "J.R.R. Tolkien", 1954, "Fantasia");
Livro livro3 = new("...E o Vento Levou", "Margaret Mitchell", 1936, "Romance");
Livro livro4 = new("Os Miseráveis", "Victor Hugo", 1862, "Drama");
Livro livro5 = new("Drácula", "Bram Stoker", 1897, "Terror");


Console.Write("Pesquisa por Gênero: (exemplo: Romance) ");
var genero = Console.ReadLine().ToLower();

if(genero == livro1.Genero.ToLower())
{
    Console.WriteLine("Livro Encontrado!\n");
    livro1.Detalhes();
}
if(genero == livro2.Genero.ToLower())
{
    Console.WriteLine("Livro Encontrado!\n");
    livro2.Detalhes();
}
if(genero == livro3.Genero.ToLower())
{
    Console.WriteLine("Livro Encontrado!\n");
    livro3.Detalhes();
}
if(genero == livro4.Genero.ToLower())
{
    Console.WriteLine("Livro Encontrado!\n");
    livro4.Detalhes();
}
if(genero == livro5.Genero.ToLower())
{
    Console.WriteLine("Livro Encontrado!\n");
    livro5.Detalhes();
}


public class Livro
{
    string Titulo;
    string Autor;
    int AnoPublicacao;
    public string Genero;

    public Livro(string titulo, string autor, int anoPublicacao, string genero)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
        Genero = genero;
    }

    public void Detalhes()
    {
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Ano de Publicação: {AnoPublicacao}");
        Console.WriteLine($"Gênero: {Genero}");
        Ler();
        Console.WriteLine();
    }

    void Ler()
    {
        Console.WriteLine($"Lendo o livro {Titulo}");
    }
}