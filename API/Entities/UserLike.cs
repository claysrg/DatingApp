using System;

namespace API.Entities;

public class UserLike
{
    public AppUser SourceUser { get; set; } = null!; // The user who liked another user
    public int SourceUserId { get; set; } // The ID of the user who liked another user
    public AppUser TargetUser { get; set; } = null!; // The user who was liked
    public int TargetUserId { get; set; } // The ID of the user who was liked
}
