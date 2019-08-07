using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project.Domain
{
    public class UserAnswer
    {
        [Key]
        public Guid Id { get; set; }

        public bool Correct { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }

        public Guid QuestionId { get; set; }
        
    }
}
