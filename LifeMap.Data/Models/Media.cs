using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeMap.Data.Model
{
    public class Media
    {
        public int MediaID { get; set; }
        public int PostID { get; set; }
        public string MediaType { get; set; } = "Image"; // "Image" или "Video"
        public string MediaData { get; set; } 
        public DateTime UploadDate { get; set; } = DateTime.Now;

        // Навигация
        public Post? Post { get; set; }
    }
}
