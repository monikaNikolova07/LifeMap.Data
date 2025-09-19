using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LifeMap.Data.Class1;
using System.Xml.Linq;

namespace LifeMap.Data.Model
{
    public class Post
    {
        public int PostID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } = null!;
        public string Location { get; set; } = null!;
        public DateTime PostDate { get; set; } = DateTime.Now;

        // Навигационни свойства
        public User User { get; set; }
        public List<Media> Media { get; set; } = new();
        public List<Comment> Comments { get; set; } = new();
        public List<Like> Likes { get; set; } = new();
    }
}
