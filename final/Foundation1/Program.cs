using System;

class Program
{
    static void Main(string[] args)
    {
        List<Videos> videos = new List<Videos>();

        Comments comments1 = new Comments("reenatai75", "Tobbias Leonard  is so realistic and understands human nature well");
        Comments comments2 = new Comments("Alec Holland", "Thank you for the great documentary.");
        Comments comments3 = new Comments("Eva Murray", "DW makes excellent documentaries.");

        List<Comments> commentsList1 = new List<Comments>();
        commentsList1.Add(comments1);
        commentsList1.Add(comments2);
        commentsList1.Add(comments3);

        Videos video1 = new Videos("A vegan lifestyle: Is it the future?", "DW Documentary", 1908, commentsList1);

        videos.Add(video1);

        Comments comments4 = new Comments("pinch", "I’ll never understand how people hate on Mr. Beast despite all the good he does. Keep it up ");
        Comments comments5 = new Comments("TimeBucks", "This is really heart touching");
        Comments comments6 = new Comments("BigFella", "Can’t believe that people get angry about you doing great things most people could never do! I love your work, thank you for everything you do!");

        List<Comments> commentsList2 = new List<Comments>();
        commentsList2.Add(comments4);
        commentsList2.Add(comments5);
        commentsList2.Add(comments6);

        Videos video2 = new Videos("Giving 20,000 Shoes To Kids In Africa", "Beast Philanthropy", 260, commentsList2);

        videos.Add(video2);

        Comments comments7 = new Comments("vidlQ", "The timing was so on point I now actually believe there are 2 MKBHDs");
        Comments comments8 = new Comments("FurthJuh", "wesome video! Hope we can get a glimpse behind the scenes on the studio channel!");
        Comments comments9 = new Comments("Divik Sonak", "Would love to see a behind-the-scenes of this M2BHD video. Great stuff!");
        Comments comments10 = new Comments("TheGamingAudiophile", "Apple has too many touch bars they’re trying to get rid of.");

        List<Comments> commentsList3 = new List<Comments>();
        commentsList3.Add(comments7);
        commentsList3.Add(comments8);
        commentsList3.Add(comments9);
        commentsList3.Add(comments10);

        Videos video3 = new Videos("M2 MacBook Pro: Why Does This Exist?", "Marques Brownlee", 464, commentsList3);

        videos.Add(video3);

        Console.WriteLine("===============================================================");
        foreach(Videos video in videos)
        {
            Console.WriteLine($"Video # {videos.IndexOf(video)+1}");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Duration (seconds): {video.GetLength()}");
            Console.WriteLine($"Number of comments: {video.CountComments()}");
            Console.WriteLine("\nComments");
            
            List<Comments> videoComments = video.GetComments();

            foreach(Comments comment in videoComments)
            {
                comment.Display();
            }
            Console.WriteLine("\n===============================================================");
        } 
    }
}
