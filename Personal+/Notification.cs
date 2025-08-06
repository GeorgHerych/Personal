using System;
using System.Collections.Generic;

namespace Personal_
{
    public class Notification
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public class NotificationRead
    {
        public int Id { get; set; }
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public DateTime ReadAt { get; set; } = DateTime.Now;
    }
}
