using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.API.Models
{
    public class UserForCreationDto
    {
        [BindProperty]
        [Required]
        [MinLength(1)]
        [MaxLength(25)]
        public string Username { get; set; }
    }
}
