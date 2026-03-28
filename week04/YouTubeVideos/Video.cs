public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _commentsList = new List<Comment>();
    public List<Video> _videoList = new List<Video>();


    public void AddComment(Comment comment)
    {
        _commentsList.Add(comment);
    }

    public void NumberOfComments() //return the number of comments
    {
        int numberOfComments = _commentsList.Count;
        Console.WriteLine($"Number of comments: {numberOfComments}");
    }

    public void AddVideo(Video video)
    {
        _videoList.Add(video);
    }

    // iterating through the list of videos
    public void DisplayVideoInfo()
    {
        foreach (Video videos in _videoList)
        {
            Console.WriteLine();
            Console.WriteLine($"Author of the video: {videos._author}");
            Console.WriteLine($"Title: {videos._title}");
            Console.WriteLine($"Length (in seconds): {videos._length}");
            videos.NumberOfComments();
            Console.WriteLine();

            foreach (Comment comment in videos._commentsList)
            {
                Console.WriteLine(comment._name);
                Console.WriteLine(comment._text);
                Console.WriteLine();
            }
        }
    }
}