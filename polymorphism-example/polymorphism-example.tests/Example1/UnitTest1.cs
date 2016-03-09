using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using polymorphism_example.Example1;

namespace polymorphism_example.tests.Example1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BillyEatsPizzaAndBanana_AssertBelly()
        {
            Person billy = new Person();
            billy.Eat(new Banana());
            billy.Eat(new Pizza());

            var actual = billy.WhatDoIHave();
            Console.WriteLine(actual);
        }
    }
}
