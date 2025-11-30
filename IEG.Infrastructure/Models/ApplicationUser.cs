using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEG.Infrastructure.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Do not redeclare UserName — it is inherited from IdentityUser
        // Add custom properties here if needed, e.g.:
        // public string? FullName { get; set; }
    }
}
