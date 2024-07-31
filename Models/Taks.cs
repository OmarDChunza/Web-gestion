using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB_GESTION.Models
{
    public class Taks
    {
       public int id { get; set; }
       public string Description { get; set; }
       public string UserId { get; set; }
       public User User { get; set; }
       public bool IsApproved { get; set; }

    }
}
