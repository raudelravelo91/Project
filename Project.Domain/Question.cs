using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Domain
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public string Text { get; set; }

        public List<string> Answers { get; set; }

        public List<string> Choices { get; set; }
    }
}
