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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool Correct { get; set; }

        public DateTime DateTime { get; set; }

        public int ConfidenceLevel { get; set; }

        public int ImportanceLevel { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public int UserId { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }

        public int QuestionId { get; set; }
        
    }
}
