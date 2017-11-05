using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SignInMP_00.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("SignInAppDB")
        {

        }

        public DbSet<Member> Members { get; set; }
        // So to keep things quick, I changed my mind and decided to have a 1-to-1 relationship between dbcontext and
        // dbset/table. Unforutnately there is no easy (for a newcomer) to migrate. This will be a good learning opportunity
        // for the future.
        public DbSet<SignIn> SignIns { get; set; }
    }
}