using System;
using System.Collections.Generic;

namespace Personal_
{
    public static class ChatService
    {
        private static readonly List<ChatMessage> messages = new List<ChatMessage>();

        public static IEnumerable<ChatMessage> GetMessages()
        {
            return messages;
        }

        public static void AddMessage(string sender, string text)
        {
            var message = new ChatMessage
            {
                Sender = sender,
                Text = text,
                Timestamp = DateTime.Now
            };
            message.ReadBy.Add(sender);
            messages.Add(message);
        }

        public static void MarkAsRead(string user)
        {
            foreach (var m in messages)
            {
                m.ReadBy.Add(user);
            }
        }
    }

    public class ChatMessage
    {
        public string Sender { get; set; }
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
        public HashSet<string> ReadBy { get; } = new HashSet<string>();
    }
}
