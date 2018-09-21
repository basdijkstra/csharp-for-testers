using NUnit.Framework;

namespace CalculatorAnswers
{
    [TestFixture]
    public class CalculatorTest
    {
        // Schrijf een test die het volgende doet:
        // 1. Maak een nieuwe instantie van de Calculator-class met default huidig totaal
        // 2. Gebruik de daarvoor bedoelde methode van deze klasse om 5 aan het totaal
        //    toe te voegen
        // 3. Controleer met een classic assertion dat het totaal inderdaad gelijk is aan 5

        [Test]
        public void AssertionTest()
        {
            // 1.
            Calculator calc = new Calculator();

            // 2.
            calc.Add(5);

            // 3.
            Assert.AreEqual(5, calc.GetCurrentTotal());
        }

        // Schrijf een test die het volgende doet
        // 1. Maak een nieuwe instantie van de Calculator-class met huidig totaal van 9
        // 2. Gebruik de daarvoor bedoelde methode van deze klasse om 2 van het totaal
        //    af te halen
        // 3. Controleer met een constraint assertion dat het totaal groter is dan 6

        [Test]
        public void SubtractTest()
        {
            // 1.
            Calculator calc = new Calculator(9);

            // 2.
            calc.Subtract(2);

            // 3.
            Assert.That(calc.GetCurrentTotal(), Is.GreaterThan(6));
        }

        // Schrijf een test die het volgende doet
        // 1. Maak een nieuwe instantie van de Calculator-class met default huidig totaal
        // 2. Voeg 3 aan het totaal toe
        // 3. Vermenigvuldig het totaal met 7
        // 4. Haal 4 van het totaal af
        // 5. Controleer met een assertion naar keuze dat het totaal ongelijk is aan 16

        [Test]
        public void AddMultiplySubtractTest()
        {
            // 1.
            Calculator calc = new Calculator();

            // 2.
            calc.Add(3);

            // 3.
            calc.Multiply(7);

            // 4.
            calc.Subtract(4);

            // 5.
            Assert.That(calc.GetCurrentTotal(), Is.Not.EqualTo(16));
            Assert.AreNotEqual(calc.GetCurrentTotal(), 16);
        }

        // Test je tests!
    }
}