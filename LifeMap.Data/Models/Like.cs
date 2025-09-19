using LifeMap.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeMap.Data.Models
{
    public class Like
    {
        public int UserID { get; set; }
        public int PostID { get; set; }

        // Навигация
        public User? User { get; set; }
        public Post? Post { get; set; }
    }
}
