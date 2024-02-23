using Help_Jacob_SOLID.Interfaces;

namespace Help_Jacob_SOLID.Classes
{
    /// <summary>
    /// Reprecents a class for sending a message via Smtp
    /// </summary>
    public class SMTPMessageSender : IMessageSender
    {
        private readonly HTMLConverter _converter;
        public SMTPMessageSender(HTMLConverter converter)
        {
            _converter = converter;
        }

        public void SendMessage(Message m)
        {
            //Example of how to use converter
            //_converter.Convert(m.Body);

            //her implementeres alt koden til at sende via Smtp
        }
        public void SendMessageToAll(string[] to, Message m)
        {
            //Example of how to use converter
            //_converter.Convert(m.Body);

            //her implementeres alt koden til at sende via Smtp
        }
    }
}
