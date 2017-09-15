
using System.Collections.Generic;

namespace DeckTracker.Models
{
    public class Format
    {
        public string FormatName {get; set;}
        public ICollection<Deck> Decks {get; set;}
    }
}