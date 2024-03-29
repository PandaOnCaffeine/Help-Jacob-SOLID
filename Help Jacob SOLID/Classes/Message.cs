﻿
namespace Help_Jacob_SOLID.Classes
{
    /// <summary>
    /// Reprecents a class for a message with To, From, Body of message, subject and cc.
    /// </summary>
    public class Message
    {
        private string to, from, body, subject, cc;

        public Message(string to, string from, string body, string subject, string cc)
        {
            this.to = to;
            this.from = from;
            this.body = body;
            this.subject = subject;
            this.cc = cc;
        }

        public string To
        {
            get => to; set => to = value;
        }
        public string From
        {
            get => from; set => from = value;
        }
        public string Body
        {
            get => body; set => body = value;
        }
        public string Subject
        {
            get => subject; set => subject = value;
        }
        public string Cc
        {
            get => cc; set => cc = value;
        }
    }
}
