using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFirstLesson.Pages;
using TwentyFirstLesson.WebDriver;

namespace TwentyFirstLesson.Tests
{
    internal class BaseTest
    {
        private string _url;
        public BaseTest(string url) { _url = url; }
        [SetUp]
        public void Setup()
        {
            BasePage.OpenPage(_url);
        }
        [TearDown]
        public void TearDown()
        {
            Driver.TearDown();
        }
    }
}
