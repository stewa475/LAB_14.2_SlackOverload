using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlackOverload.Models
{
    public class Question
    {
        //TODO: Add data annotations
        private int id;
        private string username;
        private string title;
        private string detail;
        private DateTime posted;
        private string category;
        private string tags;
        private int status;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Title { get => title; set => title = value; }
        public string Detail { get => detail; set => detail = value; }
        public DateTime Posted { get => posted; set => posted = value; }
        public string Category { get => category; set => category = value; }
        public string Tags { get => tags; set => tags = value; }
        public int Status { get => status; set => status = value; }
    }
}
