/*Crie uma classe Livro com os atributos: string Titulo, string Autor, int AnoPublicacao, 
string Genero.
a) Crie um construtor que inicialize os atributos.
b) Crie um método DetalhesLivro() que exiba todas as informações.
c) Crie um método Ler(string titulo) que exiba: "Lendo o livro {titulo}..."
d) No método DetalhesLivro(), chame Ler() passando o título do livro.
e) Instancie dois livros e exiba os detalhes.*/
Console.WriteLine("## Classe Livro ##\n");

Livro livro1 = new("O iluminado", "Stephen King",1997, "Terror");
livro1.Detalhes();

Livro livro2 = new("Harry Potter e a Pedra Filosofal", "J.K. Rowling", 1997, "Fantasia");
livro2.Detalhes();

Console.ReadKey();
public class Livro
{
    string Titulo;
    string Autor;
    int AnoPublicacao;
    string Genero; 

    public Livro(string titulo, string autor, int anoPublicacao, string genero)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
        Genero = genero;
    }

    public void Detalhes()
    {
        Console.WriteLine("Titulo: "+Titulo);
        Console.WriteLine("Autor: "+Autor);
        Console.WriteLine("Ano de Publicação: "+AnoPublicacao);
        Console.WriteLine("Genêro: "+Genero);
        Ler();
        Console.WriteLine("-------------------");
    }

    void Ler()
    {
        Console.WriteLine("Lendo o livro: "+Titulo);
    }
}