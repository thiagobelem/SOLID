using System.Net.Mail;

namespace SOLID.SRP.Solucao
{
    public class NotificacaoService
    {
        EmailService emailService;
        NomeService nomeService;

        public NotificacaoService()
        {
            emailService = new EmailService();
            nomeService = new NomeService();
        }

        public void EnviarNotificacao(string email, string nome)
        {
            nomeService.Validar(nome);
            emailService.Validar(email);

            SmtpClient smtpClient = new SmtpClient();
            MailMessage mensagem = new MailMessage("notificacao@email.com", email) { Subject = "Exemplo de Notificação", Body = "Este é um exemplo de Notificação" };
            smtpClient.Send(mensagem);
        }
    }
}
