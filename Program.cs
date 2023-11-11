using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de Dados
            Console.Write("Digite a temperatura em graus Celsius °C: ");
            string resposta = Console.ReadLine();
            double celsius = double.Parse(resposta);

            //Conversão para Kelvin
            Console.Write("Temperatura em Kelvin: ");
            double kelvin = celsius + 273.15;
            Console.WriteLine(kelvin + "K");

            //Conversão para Fahrenheit
            Console.Write("Temperatura em Fahrenheit ");
            double fahrenheit = (1.8 * celsius) + 32;
            Console.WriteLine(fahrenheit + "°F");

            Console.ReadKey();
        }
    }
}
