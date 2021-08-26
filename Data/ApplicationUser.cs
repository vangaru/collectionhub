using System.Collections.Generic;
using CollectionHub.Models;
using Microsoft.AspNetCore.Identity;

namespace CollectionHub.Data
{
    public class ApplicationUser : IdentityUser
    {
        public List<Collection> Collections { get; set; } = new();
    }
}