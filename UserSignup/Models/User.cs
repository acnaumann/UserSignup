using System;
namespace UserSignup.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(String username, String email, String password)
        {
            Username = username;
            Email = email;
            Password = password;

        }

        public User()
        {

        }
    }
}
