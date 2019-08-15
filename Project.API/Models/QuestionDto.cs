using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.API.Models
{
    public class QuestionDto
    {
        public string Text { get; set; }

        public List<string> Choices { get; set; }
    }
}
