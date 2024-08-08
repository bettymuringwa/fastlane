using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace abc20025_fastlane
{
    public class Logging
    {
        public Logging(string username, string password)
        {
            Username = username;
            Password = password;           
        }
        public string Username { get; set; }
        public string Password { get; set; }      
    }
}