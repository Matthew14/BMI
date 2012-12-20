using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BodyMassIndex
{
    public class BMI
    {
        private string name;
        private double weight;
        private double feet;
        private double inches;
        private double totalHeightInches;
        double bmi;
        
        public BMI()
        {
            this.name = "";
            this.weight = 0.0;
            this.feet = 0.0;
            this.inches = 0.0;
            this.totalHeightInches = 0.0;
        }
        public BMI(string name, double feet, double inches, double weight)
        {
            this.name = name;
            this.weight = weight;
            this.feet = feet;
            this.inches = inches;
            this.totalHeightInches = (this.feet * 12) + this.inches;
            bmi = calcBMI();
        }

        public string getName()
        {
            return this.name;
        }

        public double getFeet()
        {
            return this.feet;
        }

        public double getInches()
        {
            return this.inches;
        }

        public double getWeight()
        {
            return this.weight;
        }

        public void setName(string name)
        {
            this.name = name;         
        }

        public void setFeet(double feet)
        {
            this.feet = feet;
        }

        public void setInches(double inches)
        {
            this.inches = inches;
        }

        public void setWeight(double weight)
        {
            this.weight = weight;
        }

        public double calcBMI()
        {
            return Math.Round((this.weight / (this.totalHeightInches * this.totalHeightInches)) * 703.06957964, 2);
        }

        public string isHealthy()
        {
            if (bmi < 18.5)
                return "underweight";
            else if (bmi <= 25)
                return "healthy";
            else if (bmi <= 30)
                return "overweight";
            else
                return "obese";
        }

        public string toString()
        {
            return name+", you have a bmi of: "+bmi+". This puts you in the " +isHealthy()+" range.";
        }

    }
}
