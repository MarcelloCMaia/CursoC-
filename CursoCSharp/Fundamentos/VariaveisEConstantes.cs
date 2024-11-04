using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar() 
        {
            // Area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area e " + area);

            // Tipos internos 

            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros!
            Console.WriteLine("Menos int " + menorValorInt);

            uint populacaoBrasileira = 212_600_000;
            Console.WriteLine("Populacao brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 8_000_000_000;
            Console.WriteLine("Populacao Mundial " + populacaoMundial);

            float precoCoputador = 1299.99f;
            Console.WriteLine("Preco do computador " + precoCoputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; //Mais usado dos reais
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaDaLua = decimal.MaxValue;
            Console.WriteLine("Distancia da Lua " + distanciaDaLua);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vido ao curso!";
            Console.WriteLine(texto);
        }
    }
}
