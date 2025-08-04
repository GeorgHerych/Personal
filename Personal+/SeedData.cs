using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_
{
    public class SeedData
    {
        public static void EnsureAdminExists()
        {
            using var db = new AppDbContext();
            if (!db.Users.Any(u => u.Login == "admin"))
            {
                var hash = BCrypt.Net.BCrypt.HashPassword("Assasin123");
                db.Users.Add(new User
                {
                    Login = "admin",
                    Password = hash,
                    IsActive = true,
                });
                db.SaveChanges();
            }
        }

        public static void CreateUsar(string login, string plainPassword) {
            using var db = new AppDbContext();
            if (!db.Users.Any(u => u.Login == login))
            {
                var hash = BCrypt.Net.BCrypt.HashPassword(plainPassword);
                db.Users.Add(new User
                {
                    Login = login,
                    Password = hash,
                    IsActive = true,
                });
                db.SaveChanges();
            }
        }
    }
}
