namespace CardFlip.Objects
{
    public class Card
    {
        public int CardId { get; set; }
        public string Image { get; set; } = string.Empty;
        public bool Solved { get; set; }
    }
}
