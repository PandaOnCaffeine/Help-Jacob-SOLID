using Help_Jacob_SOLID.Interfaces;

namespace Help_Jacob_SOLID.Classes
{
    /// <summary>
    /// Reprecents a class for sending a message via VMessage (Internal System).
    /// </summary>
    public class VMessageSender : IMessageSender
    {
        private readonly HTMLConverter _converter;
        public VMessageSender(HTMLConverter converter)
        {
            _converter = converter;
        }

        public void SendMessage(Message m)
        {
            //Example of how to use converter
            //_converter.Convert(m.Body);

            //her implementeres alt koden til at sende via VMessage (Internal System)
        }
        public void SendMessageToAll(string[] to, Message m)
        {
            //Example of how to use converter
            //_converter.Convert(m.Body);

            //her implementeres alt koden til at sende via VMessage (Internal System)
        }
    }
}
