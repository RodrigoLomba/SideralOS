using SideralOS;
using System;
using System.Net;
using System.Net.Mail;

namespace SideralOS
{
    static class E_mail
    {

       

        public static void EnviarEmail(string mensagem, string assunto, string destinatario)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient()
                {
                    
                    Host = "smtp.gmail.com",
                   
                    Port = 587,

                        EnableSsl = true,

                        Credentials = new NetworkCredential(Constantes.Email, Constantes.Senha)

                };



                MailMessage mailMessage = new MailMessage()
                {
                    From = new MailAddress(Constantes.Email, "Rodrigo"),
                    Subject = assunto,
                    Body = mensagem,
                    IsBodyHtml = true

                };

                mailMessage.To.Add(destinatario);
                smtpClient.Send(mailMessage);



            }catch(Exception erro)
            {
                Tela.MostrarMensagemUsuario(erro.Message);

            }




        }


    }
}
