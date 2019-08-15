using Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.API.Models
{
    public class UserAnswerDto
    {
        public Question Question { get; set; }
        public bool Correct { get; set; }
        public DateTime DateTime { get; set; }
        public int ConfidenceLevel { get; set; }
        public int ImportanceLevel { get; set; }
    }
}
