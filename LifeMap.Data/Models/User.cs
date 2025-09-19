using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LifeMap.Data.Class1;
using System.Xml.Linq;

namespace LifeMap.Data.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string ProfilePicture { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        // Навигационни свойства
        public List<Post> Posts { get; set; } = new();
        public List<Comment> Comments { get; set; } = new();
        public List<Friendship> Friendships { get; set; } = new();
        public List<Like> Likes { get; set; } = new();
    }
}
