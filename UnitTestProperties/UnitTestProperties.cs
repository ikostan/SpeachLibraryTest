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
            //Default state Visible == false, DebugMode == false
            form.SetDebugMode();
            Assert.IsFalse(form.textBoxLogs.Visible);
            Assert.IsFalse(form.checkBoxDebugMode.Checked);
            Assert.IsFalse(form.isDebug);
        }

        [TestMethod]
        public void DebugModeTrueTest()
        {
            //Make DebugMode true
            form.checkBoxDebugMode.Checked = true;
            Assert.IsTrue(form.checkBoxDebugMode.Checked);
            form.SetDebugMode();
            Assert.IsTrue(form.isDebug);
        }

        [TestMethod]
        public void DebugModeFalseTest()
        {
            //Make DebugMode false
            form.checkBoxDebugMode.Checked = false;
            Assert.IsFalse(form.checkBoxDebugMode.Checked);
            form.SetDebugMode();
            Assert.IsFalse(form.isDebug);
        }
    }
}
