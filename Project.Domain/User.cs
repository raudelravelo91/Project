using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Domain
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public string Username { get; set; }
    }
}
