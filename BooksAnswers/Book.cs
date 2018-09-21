namespace BooksAnswers
{
    public class Book
    {
        // Voeg vier eigenschappen (properties) toe aan de klasse Book:
        // - Een titel
        // - Een auteur
        // - Een jaar van uitgave
        // - Een indicatie of een boek een eerste druk is
        // Denk goed na over de datatypen!

        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public bool IsFirstEdition { get; set; }

        // Voeg een constructor toe waarmee je de
        // waarde van iedere property kunt meegeven

        public Book(string ATitle, string AnAuthor, int AYearPublished, bool IsAFirstEdition)
        {
            this.Title = ATitle;
            this.Author = AnAuthor;
            this.YearPublished = AYearPublished;
            this.IsFirstEdition = IsAFirstEdition;
        }

        // Voeg een constructor toe zonder argumenten
        // Kies passende default waarden voor elke property
        public Book()
        {
            this.Title = "Random title";
            this.Author = "Somebody";
            this.YearPublished = 1234;
            this.IsFirstEdition = false;
        }

        // Schrijf een methode die de waarde van een boek kunstmatig verhoogte
        // door de property die aangeeft of het een eerste druk is aan te passen
        // Noem de methode ArtificiallyIncreaseValue()
        // Denk goed na over eventuele parameters

        public void ArtificiallyIncreaseValue()
        {
            this.IsFirstEdition = true;
        }

        // Schrijf een methode waarmee je de auteur van een boek kan aanpassen
        // Noem de methode SetGhostWriter()
        // Denk goed na over eventuele parameters

        public void SetGhostWriter(string GhostWriterName)
        {
            this.Author = GhostWriterName;
        }

        // Schrijf een methode ToString() die de volgende zin teruggeeft:
        // {titel}, geschreven door {auteur}, verscheen voor het eerst in {jaar van uitgave}
        // Kijk eventueel naar het voorbeeld in Cars.cs

        public override string WhatAmI()
        {
            return string.Format("{0}, geschreven door {1}, verscheen voor het eerst in {2}", this.Title, this.Author, this.YearPublished);
        }
    }
}
