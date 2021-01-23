using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCSharpNetCore
{
    public class Tests: DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            // ChromeOptions chromeOptions = new ChromeOptions();
            // chromeOptions
            Driver = new ChromeDriver();


        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']//following-sibling::div[text()='Celery']")).Click();

            string comboxControlName = "ContentPlaceHolder1_AllMealsCombo";
            //CustomControl control = new CustomControl();
            CustomControl.ComboBox(comboxControlName, "Oats");




            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}