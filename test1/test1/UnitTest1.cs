using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class test2
{
    private IWebDriver? driver;
    public IDictionary<string, object>? vars { get; private set; }
    [SetUp]
    public void SetUp()
    {
        driver = new FirefoxDriver();
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        driver.Quit();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
    [Test]
    public void Test()
    {
        driver.Navigate().GoToUrl("https://ecutbildning.se/");
        driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
        driver.FindElement(By.LinkText("Våra utbildningar")).Click();
        driver.FindElement(By.XPath("//div[@id='search-filter-results-37']/div/div/a/div/div/div/h3")).Click();
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_studiestart > .meta-title")).Text, Is.EqualTo("Utbildningstart"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_studiestart > .meta_text")).Text, Is.EqualTo("HT 2022"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_status > .meta-title")).Text, Is.EqualTo("Status"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_status > .meta_text")).Text, Is.EqualTo("Öppen för ansökan"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_kurskod > .meta-title")).Text, Is.EqualTo("Ansökningsperiod"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_kurskod > .meta_text")).Text, Is.EqualTo("01.02.2022 - 25.05.2022"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_utbildningstyp > .meta-title")).Text, Is.EqualTo("Utbildningstyp"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_utbildningstyp > .meta_text")).Text, Is.EqualTo("Yh-utbildning"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_duration > .meta-title")).Text, Is.EqualTo("Omfattning"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_duration > .meta_text")).Text, Is.EqualTo("2 år"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_lia > .meta-title")).Text, Is.EqualTo("LIA"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_lia > .meta_text")).Text, Is.EqualTo("Två LIA-perioder | Totalt: 24 veckor"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_studietakt > .meta-title")).Text, Is.EqualTo("Studietakt"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_studietakt > .meta_text")).Text, Is.EqualTo("Heltid"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_poang > .meta-title")).Text, Is.EqualTo("Poäng"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_poang > .meta_text")).Text, Is.EqualTo("400 Yhp"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_studieform > .meta-title")).Text, Is.EqualTo("Studieform"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_studieform > .meta_text")).Text, Is.EqualTo("EC Stream"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_studieort > .meta-title")).Text, Is.EqualTo("Studieort"));
        Assert.That(driver.FindElement(By.CssSelector(".utbildninger--program-meta_studieort > .meta_text")).Text, Is.EqualTo("Stockholm, Halmstad"));
    }
}