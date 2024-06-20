using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFirstLesson.Elements;

namespace TwentyFirstLesson.Pages
{
    internal class ModalDialogPage : BasePage
    {
        public static Element smallModalButton = new Element(By.XPath("//*[@id='showSmallModal']"));
        public static Element smallModalText = new Element(By.XPath("//*[@class='modal-body']"));
        public static Element smallModalButtonClose = new Element(By.XPath("//*[@id='closeSmallModal']"));
        public static Element smallModalWindow = new Element(By.XPath("//*[@class='modal-open']"));

        public static Element largeModalButton = new Element(By.XPath("//*[@id='showLargeModal']"));
        public static Element largeModalText = new Element(By.XPath("//*[@class='modal-body']"));
        public static Element largeModalButtonClose = new Element(By.XPath("//*[@id='closeLargeModal']"));
        public static Element largeModalWindow = new Element(By.XPath("//*[@class='modal-content']]"));


        public static void ButtonClick(Element button)
        {
            button.Click();
        }
        public static void ButtonCloseClick(Element buttonClose)
        {
            buttonClose.Click();
        }
        public static string GetElementText(Element text)
        {
            return text.GetText();
        }      
        
    }
}
