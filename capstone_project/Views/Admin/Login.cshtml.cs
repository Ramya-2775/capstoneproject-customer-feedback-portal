using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace capstone_project.Views.Admin
{
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}