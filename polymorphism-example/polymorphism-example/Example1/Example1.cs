using System.Collections.Generic;
using System.Text;

namespace polymorphism_example.Example1
{
    public abstract class Food
    {
        public  abstract string Describe();
    }

    public class Pizza : Food
    {
        public override string Describe()
        {
            return "a pizza";
        }
    }

    public class Banana : Food
    {
        public override string Describe()
        {
            return "an unpealed banana";
        }
    }

    public class Person
    {
        private readonly IList<Food> _belly;

        public Person()
        {
            _belly = new List<Food>();
        }

        public void Eat(Food food)
        {
            _belly.Add(food);
        }

        public string WhatDoIHave()
        {
            var sb = new StringBuilder();
            sb.AppendLine("What's in my belly:");
            foreach (var food in _belly)
            {
                sb.AppendLine(food.Describe());
            }

            return sb.ToString();
        }
    }
}
