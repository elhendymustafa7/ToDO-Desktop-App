using Microsoft.AspNetCore.Identity;

namespace ToDO_Desktop_App.Model
{
    public class user
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
