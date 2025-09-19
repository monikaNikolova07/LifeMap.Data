using LifeMap.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeMap.Data.Models
{
    public class Coments
    {
        public int CommentID { get; set; }
        public int PostID { get; set; }
        public int UserID { get; set; }
        public string Content { get; set; } = null!;
        public DateTime CommentDate { get; set; } = DateTime.Now;

        // Навигация
        public Post? Post { get; set; }
        public User? User { get; set; }
    }
}
