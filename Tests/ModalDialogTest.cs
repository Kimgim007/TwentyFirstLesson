using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFirstLesson.Elements;
using TwentyFirstLesson.Pages;

namespace TwentyFirstLesson.Tests
{
    internal class ModalDialogTest : BaseTest
    {
        private const string url = "https://demoqa.com/modal-dialogs";
        public ModalDialogTest() : base(url)
        {
        }

        [Test]
        public void SmallModalDialog()
        {         
            ModalDialogPage.ButtonClick(ModalDialogPage.smallModalButton);
            var answer = ModalDialogPage.smallModalWindow.ElementDispleed();
            Assert.That(answer,Is.True);
            const string smallModalText = "This is a small modal. It has very less content";
            var text = ModalDialogPage.GetElementText(ModalDialogPage.smallModalText);
            Assert.AreEqual(smallModalText, text);
            ModalDialogPage.ButtonCloseClick(ModalDialogPage.smallModalButtonClose);
            answer = ModalDialogPage.smallModalWindow.ElementDispleed();
            Assert.That(answer, Is.False);
        }

        [Test]
        public void LargeModalDialog()
        {
            ModalDialogPage.ButtonClick(ModalDialogPage.largeModalButton);
            var answer = ModalDialogPage.smallModalWindow.ElementDispleed();
            Assert.That(answer, Is.True);
            const string smallModalText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            var text = ModalDialogPage.GetElementText(ModalDialogPage.largeModalText);
            Assert.AreEqual(smallModalText, text);
            ModalDialogPage.ButtonCloseClick(ModalDialogPage.largeModalButtonClose);
            answer = ModalDialogPage.smallModalWindow.ElementDispleed();
            Assert.That(answer, Is.False);
        }
    }
}
