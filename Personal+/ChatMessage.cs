using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int? ReceiverId { get; set; } // null => general chat
        public string Text { get; set; }
        public DateTime SentAt { get; set; } = DateTime.Now;

        [ForeignKey(nameof(SenderId))]
        public virtual User Sender { get; set; }
        [ForeignKey(nameof(ReceiverId))]
        public virtual User Receiver { get; set; }
    }
}
