﻿namespace poster_site.DAL.Models;

public class UserRole : BaseEntity
{
    public int UserId { get; set; }
    public int RoleId { get; set; }

    // Navigation properties
    public User User { get; set; }
    public Role Role { get; set; }
}
