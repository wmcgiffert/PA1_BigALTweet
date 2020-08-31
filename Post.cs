using System.Collections.Generic;
using System;

namespace PA_1
{
    public class Post
    {
        public Guid UserID {get; set;}
        public string PostMessage {get; set;}
        public DateTime Time {get; set;}
    }
}