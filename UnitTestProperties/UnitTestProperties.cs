using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpeachLibraryTest;

namespace UnitTestProperties
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void DebugModeDefaultTest()
        {
            SpeachLibraryTestForm form = new SpeachLibraryTestForm();

            //Default state Visible == false
            form.SetDebugMode();
            Assert.IsFalse(form.textBoxLogs.Visible);
            Assert.IsFalse(form.checkBoxDebugMode.Checked);
            Assert.IsFalse(form.isDebug);
        }

        [TestMethod]
        public void DebugModeTrueTest()
        {
            SpeachLibraryTestForm form = new SpeachLibraryTestForm();

            //Make textBoxLogs visible
            form.checkBoxDebugMode.Checked = true;
            Assert.IsTrue(form.checkBoxDebugMode.Checked);
            form.SetDebugMode();
            Assert.IsTrue(form.isDebug);
            //Assert.IsTrue(form.textBoxLogs.Visible);
        }

        [TestMethod]
        public void DebugModeFalseTest()
        {
            SpeachLibraryTestForm form = new SpeachLibraryTestForm();

            //Make textBoxLogs invisible
            form.checkBoxDebugMode.Checked = false;
            Assert.IsFalse(form.checkBoxDebugMode.Checked);
            form.SetDebugMode();
            Assert.IsFalse(form.isDebug);
            Assert.IsFalse(form.textBoxLogs.Visible);
        }
    }
}
