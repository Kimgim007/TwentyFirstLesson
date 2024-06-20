using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFirstLesson.WebDriver;

namespace TwentyFirstLesson.Pages
{
    internal class BasePage
    {
        public static void OpenPage(string url)
        {
     
            Driver.GetDriver().Navigate().GoToUrl(url);
            Driver.GetDriver().Manage().Window.Maximize();
        }
    }
}
