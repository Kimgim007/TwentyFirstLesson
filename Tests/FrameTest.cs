
using TwentyFirstLesson.Pages;

namespace TwentyFirstLesson.Tests
{
    internal class FrameTest : BaseTest
    {
        private const string url = "https://demoqa.com/frames";
        public FrameTest() : base(url)
        {
        }

        [Test]
        public void FrameText()
        {
            const string title = "This is a sample page";
            FramePage.SwichFrame();
            var text = FramePage.GetElementText();
            Assert.AreEqual(title, text);
        }
    }
}
