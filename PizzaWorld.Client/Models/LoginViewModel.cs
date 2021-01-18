using System.Collections.Generic;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Client.Models
{
    public class LoginViewModel
    {
        public string CurrentUserId { get; set; }
        public List<User> AllUsers { get; set; }
    }
}