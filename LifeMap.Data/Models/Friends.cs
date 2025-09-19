using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeMap.Data.Model
{
    public class Friends
    {
        public int UserID { get; set; }
        public int FriendID { get; set; }
        public int Status { get; set; } = 0;

        // Навигация
        public User? User { get; set; }
        public User? Friend { get; set; }
    }
}
