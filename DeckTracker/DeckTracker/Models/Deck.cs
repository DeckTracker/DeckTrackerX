
using System.Collections.Generic;

namespace DeckTracker.Models
{
    public class Deck
    {
        public int DeckId {get; set;}
        public string DeckName {get; set;}
        public int FormatId {get; set;}
        public Format Format {get; set;}
        public ICollection<Models.Version> Versions {get; set;}
    }
}