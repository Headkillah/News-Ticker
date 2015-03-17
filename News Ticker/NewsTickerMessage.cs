namespace News_Ticker
{
    public class NewsTickerMessage : MessageBase
    {
        private string m_text;
        private string m_author = "News Ticker";
        public NewsTickerMessage(string message)
        {
            m_text = message;
        }

        public override string GetText()
        {
            return m_text;
        }

        public override string GetSenderName()
        {
            return m_author;
        }

        public override bool IsSimilarMessage(MessageBase other)
        {
            NewsTickerMessage newsTickerMessage = other as NewsTickerMessage;

            return newsTickerMessage != null && this.m_text == newsTickerMessage.m_text;
        }
    }
}
