using System;
using System.Collections.Generic;
using System.Text;

namespace pizzaCalories
{
    public class Dough
    {
        private const double White = 1.5;
        private const double WholeGrain = 1;
        private const double Crispy = 0.9;
        private const double Chewy = 1.1;
        private const double Homemade = 1.0;

        private double flourTypeMod;
        private double bakingTechMod;
        internal string flourType;
        private string bakingTechnique;
        private double weight;
        private double calories;

        public Dough(string flourType,string bakingTechnique, double weight)
        {
            this.flourType = flourType;
            this.bakingTechnique = bakingTechnique;
            this.Weight = weight;
            this.Calories = calories;
        }
        public double Calories
        {
            get { return this.calories; }
            private set
            {
                this.flourTypeMod = FlourTypeModifierSetter(this.flourType);
                this.bakingTechMod = BakingTechModifierSetter(this.bakingTechnique);

                calories = (2 * weight * flourTypeMod * bakingTechMod);
            }
        }
        private double Weight
        {
            get { return this.weight; }
            set
            {
                if(value<1 || value >200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }
        private double FlourTypeModifierSetter(string flourType)
        {
            if (this.flourType == "white" || this.flourType == "White")
            {
                this.flourTypeMod = White;
            }
            else if (this.flourType == "wholegrain"|| this.flourType == "Wholegrain")
            {
                this.flourTypeMod = WholeGrain;
            }
            else
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            return this.flourTypeMod;
        }
        private double BakingTechModifierSetter(string bakingTechnique)
        {
            if (bakingTechnique == "crispy"|| bakingTechnique == "Crispy")
            {
                this.bakingTechMod = Crispy;
            }
            else if (bakingTechnique == "chewy"|| bakingTechnique == "Chewy")
            {
                this.bakingTechMod = Chewy;
            }
            else if (bakingTechnique == "homemade"|| bakingTechnique == "Homemade")
            {
                this.bakingTechMod = Homemade;
            }
            else
            {
                throw new ArgumentException("Invalid type of dough."); 
            }
            return bakingTechMod;
        }
    }
}
