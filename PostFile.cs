using System;
using System.IO;
using System.Collections.Generic;
namespace PA_1
{
    public class PostFile
    {
        public static List<Post> GetPosts()
        {
            List<Post> myPost = new List<Post>();
            StreamReader inFile = new StreamReader("Posts.txt");
            
            string line = inFile.ReadLine(); //Primming Read
            while(line !=null)
            {
                string[] temp = line.Split("#");
                myPost.Add(new Post(){UserID = Guid.Parse(temp[0]),  PostMessage = temp[1], Time = DateTime.Parse(temp[2])});
                line = inFile.ReadLine(); //update read
            }

            inFile.Close();
            return myPost;
        }
    }
}