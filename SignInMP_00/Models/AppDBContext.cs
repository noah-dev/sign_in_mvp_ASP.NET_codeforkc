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
        public DbSet<SignIn> SignIns { get; set; }
    }
}