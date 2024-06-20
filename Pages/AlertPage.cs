using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Runtime.Intrinsics.X86;
using TwentyFirstLesson.Elements;
using TwentyFirstLesson.WebDriver;

namespace TwentyFirstLesson.Pages
{
    internal class AlertPage : BasePage
    {
       
        public static Element alertButton = new Element(By.XPath("//*[@id='alertButton']"));
        public static Element timerAlertButton = new Element(By.XPath("//*[@id='timerAlertButton']"));
        public static Element confirmButton = new Element(By.XPath("//*[@id='confirmButton']"));
        public static Element promtButton = new Element(By.XPath("//*[@id='promtButton']"));
        

        public static void OpenAlert(Element alert)
        {
            alert.Click();
        }

    }
}
