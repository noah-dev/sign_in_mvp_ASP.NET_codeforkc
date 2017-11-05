using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SignInMP_00.Models
{
    public class SignInDB : DbContext
    {
        // So why not the same base...? To keep things simple. Refactoring this will be a good learning
        // opportunity for the future. 
        public SignInDB() : base("SignInDB")
        {

        }
        public DbSet<SignIn> SignIns { get; set; }
    }
}