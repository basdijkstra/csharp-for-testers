using System;

namespace Cars
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Car()
        {
            Make = "Default make";
            Model = "Default model";
            Color = "Default color";
        }

        public Car(string AMake, string AModel, string AColor)
        {
            Make = AMake;
            Model = AModel;
            Color = AColor;
        }

        public override string ToString()
        {
            return string.Format("I am a {0} {1} {2}", Color, Make, Model);
        }

        public Boolean IsItalian()
        {
            string[] ItalianCarsList = {"Fiat", "Alfa Romeo", "Lancia", "Ferrari", "Maserati", "Lamborghini" };

            return (Array.IndexOf(ItalianCarsList, Make) > -1);
        }

        public void PaintCar(string newColor)
        {
            Color = newColor;
        }
    }
}
