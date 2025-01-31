using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Video 1";
        video1._author = "Author 1";
        video1._lengthInSecond = 400;

        Video video2 = new Video();
        video2._title = "Video 2";
        video2._author = "Author 2";
        video2._lengthInSecond = 200;

        Video video3 = new Video();
        video3._title = "Video 3";
        video3._author = "Author 3";
        video3._lengthInSecond = 300;

        Display(video1);
    }
}