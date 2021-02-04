using System;

namespace SOLID.LSP.Solucao
{
    public class CalculoArea
    {
        private static void ObterAreaParalelogramo(Paralelogramo paralelogramo)
        {
            Console.WriteLine("Calculo da área do Paralelogramo");
            Console.WriteLine(paralelogramo.Area());
        }

        public static void Calcular()
        {
            Retangulo retangulo = new Retangulo() { Altura = 2, Largura = 3 };
            ObterAreaParalelogramo(retangulo);

            Quadrado quadrado = new Quadrado() { Lado = 3 };
            ObterAreaParalelogramo(quadrado); 
        }
    }
}
