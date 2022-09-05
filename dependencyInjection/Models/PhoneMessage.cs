using dependencyInjection.Services;

namespace dependencyInjection.Models
{
    public class PhoneMessage: IMessage
    {
        public string Send(string message)
        {
            return "Using a Phone to send this message: " +  message;
        }
    }
}
