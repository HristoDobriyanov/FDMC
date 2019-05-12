using System;
using Microsoft.AspNetCore.Identity;

namespace FDMC.Models
{
    public class FdmcUser : IdentityUser

    {
        public string Nickname { get; set; }

        public override string UserName { get; set; }
    }
}
