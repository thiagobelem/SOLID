using System;

namespace SOLID.ISP.Violacao
{
    public class Usuario : IArquivo
    {
        public void Ler()
        {
            // Ler arquivo
        }

        public void Gravar()
        {
            throw new NotImplementedException("Usuário não tem permissão de gravação");
        }
    }
}
