namespace poster_site.DAL.Models;

public class Token : BaseEntity
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
    public DateTime ExpirationDate { get; set; }

    // Navigation properties
    public User User { get; set; }
}
