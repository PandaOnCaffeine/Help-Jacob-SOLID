using Help_Jacob_SOLID.Classes;
namespace Help_Jacob_SOLID.Interfaces
{
    public interface IMessageSender
    {
        void SendMessage(Message message);
        void SendMessageToAll(string[] to, Message message);
    }
}
