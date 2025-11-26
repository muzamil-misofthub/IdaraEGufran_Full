using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEG.Infrastructure.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? UserName { get; set; }
    }
}
