using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H34111122_practice_4_2
{
    internal class Message
    {
        public string Sender { get; set; }

        public string Text { get; set; }

        public int Emoji { get; set; }

        public Message(string sender, string text)
        {
            Sender = sender;
            Text = text;
        }

        public Message(string sender, int emoji)
        {
            Sender = sender;
            Text = "";
            Emoji = emoji;
        }
    }
}
