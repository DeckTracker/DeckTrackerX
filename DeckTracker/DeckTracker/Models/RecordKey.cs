
namespace DeckTracker.Models
{
    public class RecordKey
    {
        public int RecordKeyId {get; set;}
        public int KeyId {get; set;}
        public KeyToVictory KeyToVictory {get; set;}
        public int RecordId {get; set;}
        public Record Record {get; set;}
    }
}