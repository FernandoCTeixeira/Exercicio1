using System;
using System.Globalization;

namespace Exercicio1{

    internal class Program{

        static void Main(string[] args){

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;
            //alterando um pouco do exercicio
            double media1 = (preco1 + preco2) / 2;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2} ");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}",produto2,preco2);
            Console.WriteLine();
            Console.Write("Registro: ");
            Console.WriteLine(idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {media1:F8}");
            Console.WriteLine($"Arredondado (três casa decimais): {media1:F3})");
            Console.WriteLine("Separador decimal invariant culture:" + media1.ToString("F3", CultureInfo.InvariantCulture));
        }

    }

}