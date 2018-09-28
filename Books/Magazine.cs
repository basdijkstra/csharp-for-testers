namespace Books
{
    public class Magazine
    {
        public string Title { get; set; }
        public PublicationFrequency AppearsEvery { get; set; }
        public bool HasAdvertiments { get; set; }
        public bool IsStillRunning { get; set; }

        public Magazine(string ATitle, PublicationFrequency PubFrequency, bool ItHasAds, bool ItIsStillRunning)
        {
            Title = ATitle;
            AppearsEvery = PubFrequency;
            HasAdvertiments = ItHasAds;
            IsStillRunning = ItIsStillRunning;
        }

        public void ChangePublicationFrequencyTo(PublicationFrequency NewPubFrequency)
        {
            AppearsEvery = NewPubFrequency;
        }

        public void DiscontinueMagazine()
        {
            IsStillRunning = false;
        }

        public bool ICanAdvertiseInThisMagazine()
        {
            return HasAdvertiments && IsStillRunning;
        }

        public bool IsAMonthlyMagazine()
        {
            return AppearsEvery.Equals(PublicationFrequency.Monthly);
        }
    }
}