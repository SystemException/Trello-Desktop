namespace TrelloDesktop.Library
{
    public class Prefs
    {
        public bool SendSummaries { get; set; }
        public int MinutesBetweenSummaries { get; set; }
        public int MinutesBeforeDeadlineToNotify { get; set; }
        public bool ColorBlind { get; set; }
        public string Locale { get; set; }
    }
}