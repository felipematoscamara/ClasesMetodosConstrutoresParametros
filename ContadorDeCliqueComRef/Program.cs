/*Crie um método chamado ContarClique que recebe um contador de cliques por referência (ref) e 
incrementa ele em 1.
Chame o método algumas vezes e exiba o valor final do contador.*/
Console.WriteLine("## Contador de Clique ##\n");

int numero = 1;

Classe classe = new();
classe.ContarClique(ref numero);
classe.ContarClique(ref numero);
classe.ContarClique(ref numero);
classe.ContarClique(ref numero);

Console.WriteLine(numero);

Console.ReadKey();
public class Classe
{
    public void ContarClique(ref int i)
    {
        i++;
    }
}
