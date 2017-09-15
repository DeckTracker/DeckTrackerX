using System;
using System.Collections.Generic;

namespace DeckTracker.Models
{
    public class User
    {
        public int UserId {get; set;}
        public string UserName {get; set;}
        public string Password {get; set;}
        public string ConfirmPassword { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<TeamMember> TeamMembers {get; set;}
        public ICollection<Models.Version> Versions {get; set;}
        public ICollection<Record> Records { get; set; }
        public ICollection<Record> Wins { get; set; }
        public ICollection<Record> Losses { get; set; }
    }
}