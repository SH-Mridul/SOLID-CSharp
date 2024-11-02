namespace DI
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string name);
    }
}