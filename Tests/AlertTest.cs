using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFirstLesson.Elements;
using TwentyFirstLesson.Pages;

namespace TwentyFirstLesson.Tests
{
    internal class AlertTest : BaseTest
    {
        private const string _url = "https://demoqa.com/alerts";
        public AlertTest() : base(_url)
        {
        }

        [Test]
        public void ClickButtonToSeeAlertAndClose()
        {
            AlertPage.OpenAlert(AlertPage.alertButton);
            var answer = Element.IsAlertShow();
            Assert.That(answer, Is.True);
            Element.AcceptAlert();
            answer = Element.IsAlertShow();
            Assert.That(answer, Is.False);
        }

        [Test]
        public void CloseAlertAfterFiveSeconds()
        {
            AlertPage.OpenAlert(AlertPage.timerAlertButton);
            Thread.Sleep(6000);
            var answer = Element.IsAlertShow();       
            Assert.That(answer, Is.True);
            Element.AcceptAlert();
            answer = Element.IsAlertShow();
            Assert.That(answer, Is.False);
        }

        [Test]
        public void ConfirmButton()
        {
            AlertPage.OpenAlert(AlertPage.confirmButton);
            var answer = Element.IsAlertShow();
            Assert.That(answer, Is.True);
            Element.AcceptAlert();
            answer = Element.IsAlertShow();
            Assert.That(answer, Is.False);
        }

        [Test]
        public void PromtButton()
        {
            AlertPage.OpenAlert(AlertPage.promtButton);
            var answer = Element.IsAlertShow();
            Assert.That(answer, Is.True);
            AlertPage.promtButton.SentValue("asdasd");
            Element.AcceptAlert();
            answer = Element.IsAlertShow();
            Assert.That(answer, Is.False);
        }
    }
}
