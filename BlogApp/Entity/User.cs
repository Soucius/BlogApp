﻿namespace BlogApp.Entity;

public class User
{
    public int UserId { get; set; }
    public string? Username { get; set; }
    public List<Post> Posts { get; set; } = new List<Post>();
    public List<Comment> Comments { get; set; } = new List<Comment>();
}
