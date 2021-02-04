using System;

namespace SOLID.LSP.Violacao
{
    public class CalculoArea
    {   
        private static void ObterAreaRetangulo(Retangulo retangulo)
        {
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine(retangulo.Altura + " * " + retangulo.Largura);
            Console.WriteLine(retangulo.Area);
        }

        public static void Calcular()
        {
            Retangulo retangulo = new Retangulo() { Altura = 2, Largura = 3 };
            ObterAreaRetangulo(retangulo);

            Quadrado quadrado = new Quadrado() { Altura = 2, Largura = 3 };
            ObterAreaRetangulo(quadrado); // Vai imprimir 6 ou 9 ?
        }
    }
}
