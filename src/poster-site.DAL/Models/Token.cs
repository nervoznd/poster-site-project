using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poster_site.DAL.Models;

public class Token : BaseEntity
{
    public string AccessToken { get; set; }\
    public string RefreshToken { get; set; }
    public DateTime ExpirationDate { get; set; }
}
