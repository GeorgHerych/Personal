using System.Linq;
using System.Windows.Forms;

namespace Personal_
{
    public static class NotificationService
    {
        public static void CreateNotification(string text, int senderId)
        {
            using (var db = new AppDbContext())
            {
                db.Notifications.Add(new Notification { Text = text, SenderId = senderId });
                db.SaveChanges();
            }
        }

        public static void CheckNotifications(Form owner, User user)
        {
            using (var db = new AppDbContext())
            {
                var readIds = db.NotificationReads
                    .Where(r => r.UserId == user.Id)
                    .Select(r => r.NotificationId)
                    .ToList();
                var notifications = db.Notifications
                    .Where(n => !readIds.Contains(n.Id))
                    .ToList();
                foreach (var n in notifications)
                {
                    MessageBox.Show(owner, n.Text, "Сповіщення");
                    db.NotificationReads.Add(new NotificationRead { NotificationId = n.Id, UserId = user.Id });
                    db.SaveChanges();
                }
            }
        }
    }
}
