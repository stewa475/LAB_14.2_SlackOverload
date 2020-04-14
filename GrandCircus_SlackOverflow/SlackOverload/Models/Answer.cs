using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlackOverload.Models
{
    public class Answer
    {
        private int id;
        private string username;
        private string detail;
        private int questionid;
        private DateTime posted;
        private int upvotes;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Detail { get => detail; set => detail = value; }
        public int QuestionId { get => questionid; set => questionid = value; }
        public DateTime Posted { get => posted; set => posted = value; }
        public int Upvotes { get => upvotes; set => upvotes = value; }
    }
}
