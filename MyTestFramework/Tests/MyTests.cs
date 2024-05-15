using NUnit.Framework;
using OpenQA.Selenium;

namespace MyTestFramework
{
    public class MyTests : BaseTest
    {
               
        [Test]
        [Category("CategoryTest")]
        public void FirstTest()
        {
            Assert.That(Driver.Title, Is.EqualTo("SWAPI - The Star Wars API"));        
        }
    }
}