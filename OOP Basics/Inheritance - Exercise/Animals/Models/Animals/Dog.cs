﻿namespace Animals.Models.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dog : Animal
    {
        public Dog(string name, int age, GenderType gender) : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "BauBau";
        }
    }
}
