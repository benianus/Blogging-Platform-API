﻿namespace BloggingPlatformAPI.Models;

public class BlogPost
{
    public int Id { get; set; }
    public string Title { get; set;}
    public string content { get; set; }
    public string Category { get; set; }
    public string Tags { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
