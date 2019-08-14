using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Project.Domain
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Text { get; set; }

        [NotMapped]
        public List<string> Answers
        {
            get { return _answers; }
            set { _answers = value; }
        }

        [Required]
        public string AnswersAsString
        {
            get { return String.Join(',', _answers); }
            set { _answers = value.Split(',').ToList(); }
        }

        [NotMapped]
        public List<string> Choices
        {
            get { return _choices; }
            set { _choices = value; }
        }

        [Required]
        public string ChoicessAsString
        {
            get { return String.Join(',', _choices); }
            set { _choices = value.Split(',').ToList(); }
        }

        private List<String> _answers { get; set; }
        private List<String> _choices { get; set; }
    }
}
