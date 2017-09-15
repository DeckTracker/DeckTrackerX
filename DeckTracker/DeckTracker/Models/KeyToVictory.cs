
using System.Collections.Generic;

namespace DeckTracker.Models
{
    public class KeyToVictory
    {
        public int KeyId {get; set;}
        public string KeyName {get; set;}
        public ICollection<RecordKey> RecordKeys {get; set;}
    }
}