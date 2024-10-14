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

        // 建構函式
        public Message(string sender, string text)
        {
            Sender = sender;
            Text = text;
        }
    }
}
