using System;
using System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /**
         * Calculadora de IMC
         * @author D3m0l1d0r <SEU EMAIL AQUI>
         * @author Cascudo <lucasrochabr@outlook.com>
         */
        static void Main(string[] args)
        {
            double imc;
            double peso;
            double altura;
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            
            Console.Title = "Calculadora de IMC By D3m0l1d0r and Cascudo";
            Console.WriteLine("Calculadora de IMC By D3m0l1d0r and Cascudo");

            Console.WriteLine("Seu Peso Atual =>");
            peso = int.Parse(Console.ReadLine());

            Console.WriteLine("Sua Altura Atual =>");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (Math.Pow(altura, 2));
            Console.WriteLine("Seu IMC é " + imc.ToString());
            if (imc <= 24.9)
            {
                Console.WriteLine("Peso Ideal");
            }
            else if
            {
                (imc >= 24.9 && imc < 30)
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }
            
            //Remova os "ifs" acima e descomente a linha abaixo, caso prefira uma versão mais performática:
            //Console.WriteLine((imc <= 24.9) ? "Peso Ideal" : (imc >= 24.9 && imc < 30) ? "Sobrepeso" : "Obeso");

            Console.ReadLine();

        }
    }
}
