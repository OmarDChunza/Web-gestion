using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEB_GESTION.Models
{
    public class Taks
    {
       public int id { get; set; }
       public string? Description { get; set; }
       public required string UserId { get; set; }
       public required User User { get; set; }
       public bool IsApproved { get; set; }

    }
}
