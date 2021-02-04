using System;

namespace SOLID.OCP.Violacao
{
    public class CalculoArea
    {
        public double SomaArea(object[] formas)
        {
            double somaArea = 0;

            foreach(var forma in formas)
            { 
                if (forma is Retangulo retangulo)
                {
                    somaArea += retangulo.Altura * retangulo.Largura;
                }
                
                if(forma is Triangulo triangulo)
                {
                    somaArea += (triangulo.Base * triangulo.Altura) * 0.5;
                }

                if(forma is Circulo circulo)
                {
                    somaArea += (circulo.Raio * circulo.Raio) * Math.PI;
                }
            }
            return somaArea;
        }
    }
}
