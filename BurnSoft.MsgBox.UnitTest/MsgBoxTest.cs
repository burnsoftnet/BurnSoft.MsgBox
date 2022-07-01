using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BurnSoft.MsgBox.UnitTest
{
    [TestClass]
    public class MsgBoxTest
    {
        /// <summary>
        /// Gets or sets the test context.
        /// </summary>
        /// <value>The test context.</value>
        public TestContext TestContext { get; set; }
        /// <summary>
        /// The object
        /// </summary>
        MsgClass obj;
        [TestInitialize]
        public void Init()
        {
            obj = new MsgClass();
        }

        [TestMethod]
        public void WarningOkTest()
        {
            try
            {
                obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Inf_OK, MgBtnStyle.mb_Exclamantion,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Warning");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [TestMethod]
        public void CriticalOkTest()
        {
            try
            {
                obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Inf_OK, MgBtnStyle.mb_Critical,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Warning");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [TestMethod]
        public void QuestionOkTest()
        {
            try
            {
                obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Inf_OK, MgBtnStyle.mb_Question,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Warning");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [TestMethod]
        public void OkTest()
        {
            try
            {
                obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Inf_OK, MgBtnStyle.mb_Information,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [TestMethod]
        public void OkAudo10SecondsTest()
        {
            try
            {
                obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Inf_OK, MgBtnStyle.mb_Information,
                    "Last Backup Notice", AutoCloseTimer.ac_10Secs, true, "Info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [TestMethod]
        public void OkCancelTest()
        {
            try
            {
                obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Inf_OKCancel, MgBtnStyle.mb_Information,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [TestMethod]
        public void RetryTest()
        {
            try
            {
                obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Inf_Retry, MgBtnStyle.mb_Information,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [TestMethod]
        public void RetryCancelTest()
        {
            try
            {
                obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Inf_RetryCancel, MgBtnStyle.mb_Information,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [TestMethod]
        public void YesNoTest()
        {
            try
            {
                obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Inf_YesNo, MgBtnStyle.mb_Information,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [TestMethod]
        public void YesNoCancelTest()
        {
            try
            {
                obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Inf_YesNoCancel, MgBtnStyle.mb_Information,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
