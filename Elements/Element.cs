using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFirstLesson.WebDriver;
using OpenQA.Selenium.Interactions;

namespace TwentyFirstLesson.Elements
{
    internal class Element
    {
        private readonly By? _locator;
        private static Actions action = new Actions(Driver.GetDriver());
        public Element(By locator)
        {
            _locator = locator;
        }

        public IWebElement webElement
        {
            get
            {
                WaitWebElementPresent();
                return Driver.GetDriver().FindElement(_locator);
            }
        }

        public void WaitWebElementPresent()
        {
            Driver.WaitDriver(Driver.GetDriver(), 20).Until(q => q.FindElements(_locator).Count > 0);
        }

        public void SentValue(string value)
        {
            ScrollToElement();
            webElement.SendKeys(value);
        }

        public void Click()
        {
            ScrollToElement();
            webElement.Click();
        }

        public void ScrollToElement()
        {
            action.MoveToElement(webElement);
        }

        public static void AcceptAlert()
        {
            var alert = Driver.GetDriver().SwitchTo().Alert();
            alert.Accept();
        }

        public static bool IsAlertShow()
        {
            try
            {
                Driver.GetDriver().SwitchTo().Alert().;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public string GetText() => webElement.Text;
        public void SwitchToFrame()
        {
            Driver.GetDriver().SwitchTo().Frame(webElement);
        }
        public static void FrameExit()
        {
            Driver.GetDriver().SwitchTo().DefaultContent();
        }
        
        public bool ElementDispleed()
        {      
            try
            {  
                return Driver.GetDriver().FindElement(_locator).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false; 
            }
        }
    }
}
