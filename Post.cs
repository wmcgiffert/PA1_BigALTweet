using System.Collections.Generic;
using System;

namespace PA_1
{
    public class Post : IComparable<Post>
    {
        public Guid UserID {get; set;}
        public string PostMessage {get; set;}
        public DateTime Time {get; set;}

        public override string ToString()
        {
            return this.UserID + "#" + this.PostMessage + "#" + Time;
        }
        public int CompareTo(Post temp)
        {
            return this.UserID.CompareTo(temp.UserID);
        }
    }
}