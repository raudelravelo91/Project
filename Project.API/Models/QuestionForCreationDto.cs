using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.API.Models
{
    public class QuestionForCreationDto
    {
        [BindProperty]
        [Required]
        [MinLength(1)]
        [MaxLength(500)]
        public string Text { get; set; }

        [BindProperty]
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public List<string> Choices { get; set; }

        [BindProperty]
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public List<string> Answers { get; set; }
    }
}
