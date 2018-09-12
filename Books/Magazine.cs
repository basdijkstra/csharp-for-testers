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
            this.Title = ATitle;
            this.AppearsEvery = PubFrequency;
            this.HasAdvertiments = ItHasAds;
            this.IsStillRunning = ItIsStillRunning;
        }

        public void ChangePublicationFrequencyTo(PublicationFrequency NewPubFrequency)
        {
            this.AppearsEvery = NewPubFrequency;
        }

        public void DiscontinueMagazine()
        {
            this.IsStillRunning = false;
        }

        public bool ICanAdvertiseInThisMagazine()
        {
            return this.HasAdvertiments && this.IsStillRunning;
        }

        public bool IsAMonthlyMagazine()
        {
            return this.AppearsEvery.Equals(PublicationFrequency.Monthly);
        }
    }
}