using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Video 1", "Author 1", 400);
        //video1.DisplayCommenterInfo("Informative video");

        Video video2 = new Video("Video 2", "Author 2", 200);

        Video video3 = new Video("Video 3", "Author 3", 400);

        video1.DisplayInfo();

        video2.DisplayInfo();

        video3.DisplayInfo();        


    }
}