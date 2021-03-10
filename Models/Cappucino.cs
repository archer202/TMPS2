using CoffeLand.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Models
{
    public class Cappucino : IMakeCoffe
    {
        private Drink cappucino = new Drink();
        public Cappucino()
        {
            this.NewCappucino();
            this.cappucino.Name = "Cappucino";
        }

        public void NewCappucino()
        {
            this.cappucino = new Drink();
        }

        public void ChoiceBeans()
        {
            this.cappucino.CoffeIntensity = Enums.Intensity.Three;
        }
        public void GrindBeans()
        {
            this.cappucino.CoffeQuantity = Enums.Quantity.Medium;
        }
        public void AddWater()
        {
            this.cappucino.WaterQuantity = Enums.Quantity.Small;
        }
        public void AddMilk()
        {
            this.cappucino.MilkQuantity = Enums.Quantity.Medium;
        }
        public void AddSugar()
        {
            this.cappucino.SugarQuantity = Enums.Quantity.Medium;
        }
        public void AddCinnamon()
        {
            this.cappucino.CinnamonQuantity = Enums.Quantity.None;
        }
        public Drink GetDrink()
        {
            Drink newDrink = this.cappucino;
            this.NewCappucino();
            return newDrink;
        }
    }
}
