
namespace SOLID.OCP.Solucao
{
    public class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
