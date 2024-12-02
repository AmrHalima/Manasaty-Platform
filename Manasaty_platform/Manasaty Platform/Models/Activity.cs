using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manasaty_Platform.Models
{
    class Questions
    {
        public int Number { get; set; }
        public string Text { get; set; }
        public string[] answers = new string[4];
        public string CorrectAnswer { get; set; }

    }
    internal abstract class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeadLine { get; set;}
        public TimeSpan Duration { get; set; }
        
        public List<Questions> activityQuestions = new List<Questions> { };
        
    }
}
