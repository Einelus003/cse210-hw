using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        var video1 = new Video("How to play piano ", "Maestro Emmanuel ", 480);
        video1.AddComment(new Comment("Jeff", "This looks easy !"));
        video1.AddComment(new Comment("John", "The arpegios are difficult ."));
        video1.AddComment(new Comment("Lily", "Can you do a slow  version?"));

        var video2 = new Video("Learn happy birthday song  Minutes", " Maestro Emmanuel ", 600);
        video2.AddComment(new Comment("Mike", "Great explanation!"));
        video2.AddComment(new Comment("Sara", "Helped me understand the left hand position."));
        video2.AddComment(new Comment("Tom", "Please make one for Merry Christmas ."));

        var video3 = new Video("How to cook Pasta like a chef ", " Chef Inelus  ", 920);
        video3.AddComment(new Comment("Emma", " Looks delicious! "));
        video3.AddComment(new Comment("James", " Why you put that much garlic ."));
        video3.AddComment(new Comment("Sophia", "More pasta content please."));

        
        var videos = new List<Video> { video1, video2, video3 };

        
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}


