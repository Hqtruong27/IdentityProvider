using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knowledge.Data.Data
{
    public class User : IdentityUser
    {
        public DateTime DBO { get; set; }
    }
}
