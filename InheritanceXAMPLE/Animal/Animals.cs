using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE.Animal
{
    public class Animals
    {
        private string Animaltype;
        private double weight;
        private string name;

        public Animals(string type, double weight, string name)
        {
            Animaltype = type;
            this.weight = weight;
            this.name = name;
        }

        public Animals(string type)
        {
            weight = 0;
            Animaltype = type;
            name = string.Empty;
        }

        public Animals()
        {
            weight = 0;
            Animaltype = string.Empty;
            name = string.Empty;
        }


        public double GetWeight()
        {
            return weight;
        }

        public string GetName()
        {
            return name;
        }

        public string GetAnimalType()
        {
            return Animaltype;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetWeight(double weight)
        {
            if (weight >= 0)
                this.weight = weight;
        }

        public override string ToString()
        {
            return $"name:{name}, weight:{weight} of type: {Animaltype}";
        }

    }
}
