using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video 1", "Author 1", 400);
        Comment comment1 = new Comment("Alison", "Informative video");
        Comment comment2 = new Comment("Bob", "Useful information");
        Comment comment3 = new Comment("Cindy", "Great video");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("Video 2", "Author 2", 200);
        Comment comment4 = new Comment("David", "Interesting");
        Comment comment5 = new Comment("Eliza", "Very funny");
        Comment comment6 = new Comment("Frank", "Hilarious!");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Video video3 = new Video("Video 3", "Author 3", 400);
        Comment comment7 = new Comment("George", "I enjoyed your video");
        Comment comment8 = new Comment("Hugh", "Fantasic!");
        Comment comment9 = new Comment("Irene", "Love your presentation");
        Comment comment10 = new Comment("Jacob", "Awesome video");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);

        video1.DisplayInfo();

        video2.DisplayInfo();

        video3.DisplayInfo();        


    }
}