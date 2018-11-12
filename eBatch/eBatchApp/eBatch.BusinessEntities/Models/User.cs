using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBatch.BusinessEntities.Models
{
    public class User
    {
        public int id { get; set; } = 0;
        public string username { get; set; }
        public int? difficulty_level { get; set; }
        public bool? active { get; set; }
        public Role userRole { get; set; }

    }
}
