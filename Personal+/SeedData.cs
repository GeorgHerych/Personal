using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_
{
    public class SeedData
    {
        public static void SeedUsers()
        {
            CreateUser("dina", "dina123");
            CreateUser("oksana", "oksana123");
            CreateUser("sasha", "sasha123");
            CreateUser("zhenya", "zhenya123");
            CreateUser("vitalik", "vitalik123");
            CreateUser("stas", "stas123");
            CreateUser("yura", "admin123", true);
        }

        public static void SeedServiceMembers()
        {
            using (var db = new AppDbContext())
            {
                if (!db.ServiceMembers.Any())
                {
                    db.ServiceMembers.AddRange(new[]
                    {
                        new ServiceMember { Position = "Командир відділення", Rank = "Сержант", LastName = "Іванов", FirstName = "Іван", MiddleName = "Іванович", MovementType = "Прибуття" },
                        new ServiceMember { Position = "Стрілець", Rank = "Солдат", LastName = "Петренко", FirstName = "Петро", MiddleName = "Петрович", MovementType = "Вибуття" }
                    });
                    db.SaveChanges();
                }
            }
        }

        private static void CreateUser(string login, string plainPassword, bool isAdmin = false)
        {
            using (var db = new AppDbContext())
            {
                if (!db.Users.Any(u => u.Login == login))
                {
                    var hash = BCrypt.Net.BCrypt.HashPassword(plainPassword);
                    db.Users.Add(new User
                    {
                        Login = login,
                        Password = hash,
                        IsActive = true,
                        IsAdmin = isAdmin,
                    });
                    db.SaveChanges();
                }
            }
        }
    }
}
