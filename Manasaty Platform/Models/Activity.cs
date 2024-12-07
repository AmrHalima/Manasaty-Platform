using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manasaty_Platform.Models
{
    class Question
    {
        public int Number { get; set; }
        //public string[] Text =new string[Number];
        public string Text { get; set; }
        public string[] choices = new string[4];
        public string CorrectAnswer { get; set; }

        public Question() { }

        public Question(int number, string text, string[] choices, string correctAnswer)
        {
            Number = number;
            Text = text;
            if (choices.Length == 4)
            {
                this.choices = choices;
            }
            else
            {
                throw new ArgumentException("Exactly 4 answers are required.");
            }
            CorrectAnswer = correctAnswer;
        }
    }
    internal abstract class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeadLine { get; set; }
        public TimeSpan Duration { get; set; }

        //-------data of take the quiz or exercise
        public double grade { get; set; }
        public DateTime atempData { get; set; }
        //-------

        public List<Question> activityQuestions = new List<Question> { };

        public Activity() { }

        public Activity(int id, string name, string description, DateTime createdDate, DateTime deadLine, TimeSpan duration, List<Question> question,double grade,DateTime atempData)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedDate = createdDate;
            DeadLine = deadLine;
            Duration = duration;
            this.atempData = atempData;
            this.grade=grade;
        }

    }
}
