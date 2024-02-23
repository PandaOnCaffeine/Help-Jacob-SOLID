using Help_Jacob_SOLID.Interfaces;

namespace Help_Jacob_SOLID.Classes
{
    /// <summary>
    /// Reprecents a class for sending a message via Smtp
    /// </summary>
    public class SMTPMessageSender : IMessageSender
    {
        public void SendMessage(Message m)
        {
            //her implementeres alt koden til at sende via Smtp
        }
        public void SendMessageToAll(string[] to, Message m)
        {
            //her implementeres alt koden til at sende via Smtp
        }
    }
}
