using System;

namespace SOLID.SRP.Solucao
{
    public class NomeService
    {
        public void Validar(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Nome inválido");
            }
        }
    }
}
