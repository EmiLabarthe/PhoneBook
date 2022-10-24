namespace Library
{
    public interface IMessageChannel
    {
         void Send(Message message);
         Message GetMessage(Contact from, Contact to);
    }
}