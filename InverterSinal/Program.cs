/*Crie um método chamado InverterSinal:
Um que recebe um número por valor e retorna o número com o sinal invertido.
Outro que recebe um número por referência e inverte o sinal diretamente na variável.
Mostre o comportamento de ambos no Main.*/

Console.WriteLine("## Inverter Sinal ##\n");

Classe classe = new();
int numero = classe.InverterSinal(-10);
Console.WriteLine(numero);

Console.ReadKey();
 
public class Classe
{
    public int InverterSinal(int numero)
    {
        return -numero;
    }
}