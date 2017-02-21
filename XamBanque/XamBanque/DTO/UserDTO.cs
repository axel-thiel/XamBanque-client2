using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamBanque.DTO
{
    class UserDTO
    {
        private long id { get; set; }
        private String lastName { get; set; }
        private long firstName { get; set; }
        private long login { get; set; }
        private long password { get; set; }
        private String email { get; set; }
        private int phone { get; set; }
        private int bankId { get; set; }
    }
}
