﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task1.Tests
{
    public abstract class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public virtual void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--no-sandbox");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown() { 
            driver.Quit();
            driver.Dispose();
        }
    }
}
