using Help_Jacob_SOLID.Interfaces;

namespace Help_Jacob_SOLID.Classes
{
    /// <summary>
    /// Reprecents a class for sending a message via VMessage (Internal System).
    /// </summary>
    public class VMessageSender : IMessageSender
    {
        public void SendMessage(Message message)
        {
            //her implementeres alt koden til at sende via VMessage (Internal System)
        }
        public void SendMessageToAll(string[] to, Message message)
        {
            //her implementeres alt koden til at sende via VMessage (Internal System)
        }
    }
}
