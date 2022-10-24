using WhatsAppApiUCU;

namespace Library
{
    public class WhatsApp: IMessageChannel
    {
        public void Send(Message message)
        {
            var whatsApp = new WhatsAppApi();
            whatsApp.Send(message.To, message.Text);
        }
        public Message GetMessage(Contact from, Contact to)
        {
            Message message = new WhatsAppMessage(from.Phone, to.Phone);
            return message;
        }
    }
}