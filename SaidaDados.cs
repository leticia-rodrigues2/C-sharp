﻿using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class SaidaDados
    {
        public void MostrarSaidaDados()
        {
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';
            int idade = 26;

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", z, idade, x);
            Console.WriteLine($"{z} tem {idade} anos e tem saldo igual a {x:F2} reais");
        }
    }
}
