
namespace SOLID.OCP.Solucao
{
    public class CalculoArea
    {
        public double SomaArea(Forma[] formas)
        {
            double somaArea = 0;

            foreach (var forma in formas)
            {
                somaArea += forma.Area();
            }

            return somaArea;
        }
    }
}
