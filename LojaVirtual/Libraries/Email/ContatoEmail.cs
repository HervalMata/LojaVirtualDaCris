using System.Net;
using System.Net.Mail;
using LojaVirtual.Models;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("camasilva84@gmail.com", "");
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("<h2>Contato - Loja de Laços da Cris</h2>" +
                                            "<b>Nome: </b> {0} <br/>" +
                                            "<b>Email: </b> {1} <br/>" +
                                            "<b>Texto: </b> {2} <br/>" +
                                            "<br/> Email enviado automaticamente do site Loja de Laços da Cris.",
                contato.Nome,
                contato.Email,
                contato.Texto);

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(contato.Email);
            mensagem.To.Add("camasilva84@gmail.com");
            mensagem.Subject = "Contato - Loja de Laços da Cris - Email: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;
            
            smtp.Send(mensagem);
        }
    }
}