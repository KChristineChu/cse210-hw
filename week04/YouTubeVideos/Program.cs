using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Video 1";
        video1._author = "Author 1";
        video1._lengthInSecond = 400;
        video1.AddComment(new Comment("Ali", "Informative"));
        video1.AddComment(new Comment("Bob", "Useful information."));;
        video1.AddComment(new Comment("Cindy", "Great video"));

        Video video2 = new Video();
        video2._title = "Video 2";
        video2._author = "Author 2";
        video2._lengthInSecond = 200;
        video2.AddComment(new Comment("David", "Interesting"));
        video2.AddComment(new Comment("Elly", "Very funny"));
        video2.AddComment(new Comment("Frank", "Hilarious"));

        Video video3 = new Video();
        video3._title = "Video 3";
        video3._author = "Author 3";
        video3._lengthInSecond = 300;
        video3.AddComment(new Comment("Gigi", "I enjoyed your video"));
        video3.AddComment(new Comment("Hugh", "Fantastic"));
        video3.AddComment(new Comment("Ivory", "Love your presentation"));


        video1.DisplayInfo();


        video2.DisplayInfo();


        video3.DisplayInfo();
    }
}