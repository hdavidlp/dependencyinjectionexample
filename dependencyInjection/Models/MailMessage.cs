using dependencyInjection.Services;

namespace dependencyInjection.Models
{
    public class MailMessage:IMessage
    {
        public string Send(string message)
        {
            return "Using a e-mail to send this message: " + message;
        }

    }
}
