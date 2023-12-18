using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class ExercicioSaidaDados
    {
        public void Exercicio1()
        {
          string produto1 = "Computador";
          string produto2 = "Mesa de escrotório";
          byte idade = 26;
          int codigo =5290;
          char genero ='M';

          double preco1 = 2100.00;
          double preco2 = 650.50;
          double media = 53.234567;

         Console.WriteLine($"Produtos:");
         Console.WriteLine($"{produto1} cujo preço é $ {preco1:F2}");
         Console.WriteLine($"{produto2} , cujo preço é $ {preco2:F2}");
         Console.WriteLine();
         Console.WriteLine($"Registro : {idade} anos de idade, codigo {codigo} e genero : {genero}");
         Console.WriteLine();
         Console.WriteLine($"Medida com oito casas decimais : {media:F8}");
         Console.WriteLine($"ARREDONDAR 3 casas decimais : {media:F3}");
         Console.WriteLine($"Separador decimal invariant culture : {media.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
