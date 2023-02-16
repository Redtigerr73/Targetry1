﻿namespace Targetry.UI.Blazor.Data
{
    public class QuizItem
    {
        public string Question { get; set; }
        public List<string> Choices { get; set; }
        public int AnswerIndex { get; set; }
        public int Score { get; set; }

        public QuizItem()
        {
            Choices = new List<string>();
        }
    }
}
