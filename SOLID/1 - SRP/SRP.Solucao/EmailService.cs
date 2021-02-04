using System;

namespace SOLID.SRP.Solucao
{
    public class EmailService
    {
        public void Validar(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new Exception("Email inválido");
            }
        }
    }
}
