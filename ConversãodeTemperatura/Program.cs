/* Você deve criar um programa em C# para converter temperaturas informadas em graus Celsius, 
 * obtendo como resultado tanto a temperatura em Fahrenheit quanto em Kelvin. Para isso, será 
 * necessário utilizar um método com parâmetro de saída (out), permitindo retornar dois valores 
 * diferentes a partir de um único método.
 
Criar uma classe chamada Temperatura.
Dentro dessa classe, criar um método chamado ConverterCelsius.

Esse método deverá:
Receber um valor em graus Celsius (tipo double);
Calcular a temperatura equivalente em Fahrenheit usando a fórmula: Fahrenheit = (Celsius × 9/5) + 32
Calcular a temperatura equivalente em Kelvin, usando a fórmula: Kelvin = Celsius + 273.15
Retornar o valor em Fahrenheit como valor de retorno do método.
Retornar o valor em Kelvin através de um parâmetro out.

No método Main, você deve:
Criar uma instância da classe Temperatura;
Informar uma temperatura em Celsius;
Chamar o método ConverterCelsius;
Exibir os valores convertidos em Fahrenheit e Kelvin no console.*/

Console.WriteLine("## Conversão de Temperatura ##\n");

Temperatura temperatura = new();
double kelvin;
double fahrenheit = temperatura.ConverterCelsius(30, out kelvin);

Console.WriteLine($"30°C -> {kelvin}°K");
Console.WriteLine($"30°C -> {fahrenheit}°F");

Console.ReadKey();

public class Temperatura
{
    public double ConverterCelsius(double celsius, out double kelvin)
    {
        kelvin = celsius + 273.15;
        celsius = (celsius * 9 / 5) + 32;
        return celsius;
    }
}