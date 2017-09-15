
using System;
using System.Collections.Generic;

namespace DeckTracker.Models
{
    public class Version
    {
        public int VersionId {get; set;}
        public int DeckId {get; set;}
        public Deck Deck {get; set;}
        public int AuthorId {get; set;}
        public User Author {get; set;}
        public string DeckList {get; set;}
        public string VersionName {get; set;}
        public DateTime DateCreated { get; set; }
        public ICollection<Record> Records { get; set; }
        public ICollection<Record> VersionWins { get; set; }
        public ICollection<Record> VersionLosses { get; set; }
    }
}