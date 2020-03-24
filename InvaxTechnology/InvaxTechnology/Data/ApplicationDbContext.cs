using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvaxTechnology.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
