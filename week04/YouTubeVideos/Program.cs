using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video 1", "Author 1", 400);
        video1.AddComment(new Comment("Alison", "Informative video"));
        video1.AddComment(new Comment("Bob", "Useful information"));
        video1.AddComment(new Comment("Cindy", "Great video"));

        Video video2 = new Video("Video 2", "Author 2", 200);
        video2.AddComment(new Comment("David", "Interesting"));
        video2.AddComment(new Comment("Eliza", "Very funny"));
        video2.AddComment(new Comment("Frank", "Hilarious!"));


        Video video3 = new Video("Video 3", "Author 3", 400);
        video3.AddComment(new Comment("George", "I enjoyed your video"));
        video3.AddComment(new Comment("Hugh", "Fantasic!"));
        video3.AddComment(new Comment("Irene", "Love your presentation"));
        video3.AddComment(new Comment("Jacob", "Awesome video"));

        video1.DisplayInfo();

        video2.DisplayInfo();

        video3.DisplayInfo();        


    }
}