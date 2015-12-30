using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame
{
    public class QuestionPair
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }

    public class QuestionSet
    {
        public int Points { get; set; }
        public QuestionPair Question { get; set; }
    }

    public class CategoryModel
    {
        public List<QuestionSet> Questions { get; set; }
        public string CategoryName { get; set; }
        public string CategoryTitle { get; set; }
    }
}
