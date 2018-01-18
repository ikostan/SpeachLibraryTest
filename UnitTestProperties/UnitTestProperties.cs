using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpeachLibraryTest;

namespace UnitTestProperties
{
    [TestClass]
    public class UnitTest
    {
        //Instantiate the object
        private SpeachLibraryTestForm form = new SpeachLibraryTestForm();

        [TestMethod]
        public void DebugModeFormObjectTest()
        {
            Assert.IsNotNull(form);
            Assert.IsInstanceOfType(form, typeof(SpeachLibraryTestForm));
        }

        [TestMethod]
        public void DebugModeDefaultTest()
        {
            //Default state Visible == false
            form.SetDebugMode();
            Assert.IsFalse(form.textBoxLogs.Visible);
            Assert.IsFalse(form.checkBoxDebugMode.Checked);
            Assert.IsFalse(form.isDebug);
        }

        [TestMethod]
        public void DebugModeTrueTest()
        {
            //Make textBoxLogs visible
            form.checkBoxDebugMode.Checked = true;
            Assert.IsTrue(form.checkBoxDebugMode.Checked);
            form.SetDebugMode();
            Assert.IsTrue(form.isDebug);
        }

        [TestMethod]
        public void DebugModeFalseTest()
        {
            //Make textBoxLogs invisible
            form.checkBoxDebugMode.Checked = false;
            Assert.IsFalse(form.checkBoxDebugMode.Checked);
            form.SetDebugMode();
            Assert.IsFalse(form.isDebug);
        }
    }
}
