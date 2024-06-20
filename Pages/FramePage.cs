using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFirstLesson.Elements;

namespace TwentyFirstLesson.Pages
{
    internal class FramePage:BasePage
    {
        private static Element FirstTrameText = new Element(By.XPath("//*[@id='sampleHeading']"));
        private static Element FirstFrame = new Element(By.XPath(" //*[@id='frame1']"));
       
        public static void SwichFrame()
        {
            FirstFrame.SwitchToFrame();
        }
        public static string GetElementText()
        {
            return FirstTrameText.GetText();
        }
    }
}
