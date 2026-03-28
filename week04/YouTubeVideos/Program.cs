using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        // first video with 3 comments
        Video video = new Video();
        video._author = "MrBeast";
        video._title = "Feeding starving children in Africa!";
        video._length = 1538;

        Comment comment = new Comment();
        comment._name = "Juan Sebastian";
        comment._text = "Great video! It is so good and heartwarming to see you help people around the world! Thanks MrBeast!";
        video.AddComment(comment);

        Comment comment2 = new Comment();
        comment2._name = "Alex_R23";
        comment2._text = "This is why I respect MrBeast so much. Using his platform to actually help people instead of just chasing views 👏";
        video.AddComment(comment2);

        Comment comment3 = new Comment();
        comment3._name = "MayaK";
        comment3._text = "Seeing the kids smile like that really got me… 🥹 more creators should be doing stuff like this.";
        video.AddComment(comment3);

        video.AddVideo(video);


        // second video and its comments
        Video video2 = new Video();
        video2._author = "Dude Perfect";
        video2._title = "Top 10 HARDEST trickshots!";
        video2._length = 754;

        Comment commentVid2 = new Comment();
        commentVid2._name = "JordanPlays";
        commentVid2._text = "People can say what they want, but this is actually insane. Respect.";
        video2.AddComment(commentVid2);

        Comment comment2Vid2 = new Comment();
        comment2Vid2._name = "Lina_07";
        comment2Vid2._text = "Number 1 was insane, I still don’t understand how that even worked 😳";
        video2.AddComment(comment2Vid2);

        Comment comment3Vid2 = new Comment();
        comment3Vid2._name = "KyleM";
        comment3Vid2._text = "The amount of attempts behind these shots must be crazy. Worth it though!";
        video2.AddComment(comment3Vid2);

        video.AddVideo(video2);


        // third video and its 4 comments
        Video video3 = new Video();
        video3._author = "The Church of Jesus Christ of Latter Day Saints";
        video3._title = "Greater Love: A message of Hope from the First Presidency";
        video3._length = 147;

        Comment comment1Vid3 = new Comment();
        comment1Vid3._name = "ChrisVlogs";
        comment1Vid3._text = "This message should be played in every screen in the world. Real men worship God 💪";
        video3.AddComment(comment1Vid3);

        Comment comment2Vid3 = new Comment();
        comment2Vid3._name = "FaithJourney";
        comment2Vid3._text = "This message came at the perfect time for me. Really needed this reminder of hope ❤️";
        video3.AddComment(comment2Vid3);

        Comment comment3Vid3 = new Comment();
        comment3Vid3._name = "Daniel_87";
        comment3Vid3._text = "So peaceful and uplifting. I always feel better after listening to messages like this.";
        video3.AddComment(comment3Vid3);

        Comment comment4Vid3 = new Comment();
        comment4Vid3._name = "MariaL";
        comment4Vid3._text = "Simple and powerful. Definitely something I’ll come back and watch again.";
        video3.AddComment(comment4Vid3);

        video.AddVideo(video3);

        // iterating through the list of videos and displaying video information
        video.DisplayVideoInfo();
    }
}