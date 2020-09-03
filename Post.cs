using System.Collections.Generic;
using System.IO;
using System;

namespace PA_1
{
    public class Post : IComparable<Post>
    {
        public Guid PostID {get; set;}
        public string PostMessage {get; set;}
        public DateTime Time {get; set;}

        public override string ToString()
        {
            return this.PostID + "#" + this.PostMessage + "#" + Time;
        }
        public int CompareTo(Post temp)
        {
            return this.PostID.CompareTo(temp.PostID);
        }
        public static int CompareByDate(Post x, Post y)
        {
            return x.Time.CompareTo(y.Time);
        }
        public static void ReverseSort(List<Post> tweet)
        {
            tweet.Sort(Post.CompareByDate);
            tweet.Reverse();
            ShowAllPost(tweet);
        }
        public static void ShowAllPost(List<Post> tweet)
        {
            
            foreach (Post posts in tweet)
            {
                Console.WriteLine($"Post ID :{posts.PostID} :Tweet: {posts.PostMessage} :Date & Time: {posts.Time}");
            }
            
        }
        public static void AddPost(List<Post> tweet)
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter your tweet");
            Console.WriteLine("");

            string userTweet = Console.ReadLine();

            tweet.Add(new Post(){PostID = Guid.NewGuid(),  PostMessage = userTweet, Time = DateTime.Now});

            ReverseSort(tweet);
            PostFile.SavePost(tweet);
        }
        public static void DeletePost(List<Post> tweet)
        {
            ShowAllPost(tweet);
            Console.WriteLine("Please enter the Post Id you would like to delete");
            
            string temp = Console.ReadLine();
            Guid selection;

            bool valid = Guid.TryParse(temp, out selection);
            while(valid == false)
            {
                Console.WriteLine("");
                Console.WriteLine("Error Please enter a valid Post ID");
                Console.WriteLine("");

                temp = Console.ReadLine();
                valid = Guid.TryParse(temp, out selection);

            }
            
            // Guid selection = Guid.Parse(Console.ReadLine());
            

            int index = tweet.FindIndex(x=> x.PostID == selection);
            if(index != -1)
            {
                tweet.RemoveAt(index);
            }else
            {
                Console.WriteLine("");
                Console.WriteLine("Could not find Post ID");
                Console.WriteLine("");
            }
            

            ReverseSort(tweet);
            PostFile.SavePost(tweet);
        }
    }
}