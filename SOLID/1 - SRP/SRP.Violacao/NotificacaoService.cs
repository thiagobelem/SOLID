using System;
using System.Net.Mail;

namespace SOLID.SRP.Violacao
{
    public class NotificacaoService
    {
        public void EnviarNotificacao(string email, string nome)
        {
            if(string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Nome inválido");
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new Exception("Email inválido");
            }

            SmtpClient smtpClient = new SmtpClient();
            MailMessage mensagem = new MailMessage("notificacao@email.com", email) { Subject = "Exemplo de Notificação", Body = "Este é um exemplo de Notificação" };
            smtpClient.Send(mensagem);
        }
    }
}
