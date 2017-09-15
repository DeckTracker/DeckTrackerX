
using System;

namespace DeckTracker.Models
{
    public class Record
    {
        public int RecordId {get; set;}
        public int WinnerUserId {get; set;}
        public User Winner {get; set;}
        public int LoserUserId { get; set; }
        public User Loser { get; set; }
        public int WinningVersionId {get; set; }
        public Models.Version WinningVersion {get; set;}
        public int LosingVersionId { get; set; }
        public Models.Version LosingVersion { get; set; }
        public int WinnerMulligan {get; set;}
        public int LoserMulligan {get; set;}
        public bool BoardedGame {get; set;}
        public int Closeness {get; set;}
        public string Notes {get; set;}
        public DateTime DateCreated { get; set; }
    }
}