using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Domain
{
    public class Question
    {
        [Key]
        public Guid Id { get; set; }

        public string Text { get; set; }
    }
}
