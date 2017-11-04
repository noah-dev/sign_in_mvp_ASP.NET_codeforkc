using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SignInMP_00.Models
{
    public class SignInDB : DbContext
    {
        public SignInDB() : base("SignInDB")
        {

        }

        public DbSet<Member> Members {get; set;}

        public DbSet<SignIn> SignIns { get; set; }
    }
}