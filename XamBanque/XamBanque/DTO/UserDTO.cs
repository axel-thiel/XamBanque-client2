using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamBanque.DTO
{
    public class UserDTO
    {
        public long id { get; set; }
        public String lastName { get; set; }
        public String firstName { get; set; }
        public String email { get; set; }
        public int phone { get; set; }
        public int bankId { get; set; }
    }
}
