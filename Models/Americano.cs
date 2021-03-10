using CoffeLand.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeLand.Models
{
    public class Americano : IMakeCoffe
    {
        private Drink americano = new Drink();
        public Americano()
        {
            this.NewAmericano();
            this.americano.Name = "Americano";
        }

        public void NewAmericano()
        {
            this.americano = new Drink();
        }

        public void ChoiceBeans()
        {
            this.americano.CoffeIntensity = Enums.Intensity.Three;
        }
        public void GrindBeans()
        {
            this.americano.CoffeQuantity = Enums.Quantity.Medium;
        }
        public void AddWater()
        {
            this.americano.WaterQuantity = Enums.Quantity.Medium;
        }
        public void AddMilk()
        {
            this.americano.MilkQuantity = Enums.Quantity.None;
        }
        public void AddSugar()
        {
            this.americano.SugarQuantity = Enums.Quantity.Medium;
        }
        public void AddCinnamon()
        {
            this.americano.CinnamonQuantity = Enums.Quantity.Small;
        }
        public Drink GetDrink()
        {
            Drink newDrink = this.americano;
            this.NewAmericano();
            return newDrink;
        }
    }
}
