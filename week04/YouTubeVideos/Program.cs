using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store Video objects
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("10 Amazing Programming Tips", "CodeMaster Pro", 720);
        
        // Add comments to video1
        Comment comment1Video1 = new Comment("TechEnthusiast", "Great tips! This really helped me improve my coding.");
        Comment comment2Video1 = new Comment("BeginnerCoder", "Thank you for explaining this so clearly!");
        Comment comment3Video1 = new Comment("DevExpert", "Tip #7 was exactly what I needed for my project.");
        
        video1.AddComment(comment1Video1);
        video1.AddComment(comment2Video1);
        video1.AddComment(comment3Video1);
        
        videoList.Add(video1);

        // Create Video 2 with title, author, and length (in seconds)
        Video video2 = new Video("Learn C# in 30 Minutes", "QuickLearn Academy", 1800);
        
        // Add comments to video2
        Comment comment1Video2 = new Comment("CSharpNewbie", "This is the best C# tutorial I've found!");
        Comment comment2Video2 = new Comment("ProgrammingFan", "Very comprehensive for just 30 minutes.");
        Comment comment3Video2 = new Comment("CodeReviewer", "Good pace and clear examples throughout.");
        
        video2.AddComment(comment1Video2);
        video2.AddComment(comment2Video2);
        video2.AddComment(comment3Video2);
        
        videoList.Add(video2);

        // Create Video 3 with title, author, and length (in seconds)
        Video video3 = new Video("Object-Oriented Programming Explained", "EduTech Channel", 960);
        
        // Add comments to video3
        Comment comment1Video3 = new Comment("OOPLearner", "Finally understand inheritance and polymorphism!");
        Comment comment2Video3 = new Comment("SoftwareStudent", "The examples with animals and vehicles were perfect.");
        Comment comment3Video3 = new Comment("AbstractThinker", "Abstraction section was particularly well done.");
        Comment comment4Video3 = new Comment("EncapsulationExpert", "Great explanation of private vs public members.");
        
        video3.AddComment(comment1Video3);
        video3.AddComment(comment2Video3);
        video3.AddComment(comment3Video3);
        video3.AddComment(comment4Video3);
        
        videoList.Add(video3);
        Video video4 = new Video("5 Common Programming Mistakes to Avoid", "CleanCode Guru", 540);
        
        // Add comments to video4
        Comment comment1Video4 = new Comment("ErrorProne", "I was making mistake #3 all the time! Thanks for pointing it out.");
        Comment comment2Video4 = new Comment("QualityCode", "These tips will save me so much debugging time.");
        Comment comment3Video4 = new Comment("RefactorMaster", "Everyone should watch this before writing their next program.");
        
        video4.AddComment(comment1Video4);
        video4.AddComment(comment2Video4);
        video4.AddComment(comment3Video4);
        
        videoList.Add(video4);

        // Iterate through the list of videos and display information
        Console.WriteLine("YouTube Video Analysis Report");
        Console.WriteLine("============================");
        Console.WriteLine();

        foreach (Video currentVideo in videoList)
        {
            // Display title, author, length, and number of comments (using the method)
            Console.WriteLine($"Title: {currentVideo.GetTitle()}");
            Console.WriteLine($"Author: {currentVideo.GetAuthor()}");
            Console.WriteLine($"Length: {currentVideo.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {currentVideo.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            
            // Display all comments for this video (commenter's name and text)
            List<Comment> videoComments = currentVideo.GetComments();
            foreach (Comment currentComment in videoComments)
            {
                Console.WriteLine($"  - {currentComment.GetCommenterName()}: {currentComment.GetCommentText()}");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Analysis complete. Total videos processed: {videoList.Count}");
    }
}

// by alvine kinyera was tricky but fun.