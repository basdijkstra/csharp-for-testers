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
            this.Make = "Default make";
            this.Model = "Default model";
            this.Color = "Default color";
        }

        public Car(string AMake, string AModel, string AColor)
        {
            this.Make = AMake;
            this.Model = AModel;
            this.Color = AColor;
        }

        public override string WhatAmI()
        {
            return string.Format("I am a {0} {1} {2}", this.Color, this.Make, this.Model);
        }

        public Boolean IsItalian()
        {
            string[] ItalianCarsList = {"Fiat", "Alfa Romeo", "Lancia", "Ferrari", "Maserati", "Lamborghini" };

            return (Array.IndexOf(ItalianCarsList, this.Make) > -1);
        }

        public void PaintCar(string newColor)
        {
            this.Color = newColor;
        }
    }
}
