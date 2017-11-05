using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignInMP_00.Models
{
    public class SignIn
    {
        public int Id { get; set; }
        [Required]
        public int MemberId { get; set; }
        public int DateTimeUnix { get; set; }
    }
}