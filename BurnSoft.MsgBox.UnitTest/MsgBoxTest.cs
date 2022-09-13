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
        MsgClass _obj;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            _obj = new MsgClass();
        }
        /// <summary>
        /// Defines the test method WarningOkTest.
        /// </summary>
        [TestMethod, TestCategory("Ok Button")]
        public void WarningOkTest()
        {
            try
            {
                _obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Ok, MgBtnStyle.Exclamantion,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Warning");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        /// <summary>
        /// Defines the test method CriticalOkTest.
        /// </summary>
        [TestMethod, TestCategory("Ok Button")]
        public void CriticalOkTest()
        {
            try
            {
                _obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Ok, MgBtnStyle.Critical,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Warning");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        /// <summary>
        /// Defines the test method QuestionOkTest.
        /// </summary>
        [TestMethod, TestCategory("Ok Button")]
        public void QuestionOkTest()
        {
            try
            {
                _obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Ok, MgBtnStyle.Question,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Warning");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        /// <summary>
        /// Defines the test method OkTest.
        /// </summary>
        [TestMethod, TestCategory("Ok Button")]
        public void OkTest()
        {
            try
            {
                _obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Ok, MgBtnStyle.Information,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        /// <summary>
        /// Defines the test method OkAudo10SecondsTest.
        /// </summary>
        [TestMethod, TestCategory("Ok Button")]
        public void OkAudo10SecondsTest()
        {
            try
            {
                _obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Ok, MgBtnStyle.Information,
                    "Last Backup Notice", AutoCloseTimer.ac_10Secs, true, "Info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        /// <summary>
        /// Defines the test method OkCancelTest.
        /// </summary>
        [TestMethod, TestCategory("Ok/Cancel Button")]
        public void OkCancelTest()
        {
            try
            {
                _obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.OkCancel, MgBtnStyle.Information,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        /// <summary>
        /// Defines the test method RetryTest.
        /// </summary>
        [TestMethod, TestCategory("Retry Button")]
        public void RetryTest()
        {
            try
            {
                _obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Retry, MgBtnStyle.Information,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        /// <summary>
        /// Defines the test method RetryCancelTest.
        /// </summary>
        [TestMethod, TestCategory("Retry/Cancel Button")]
        public void RetryCancelTest()
        {
            try
            {
                _obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.RetryCancel, MgBtnStyle.Information,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        /// <summary>
        /// Defines the test method YesNoTest.
        /// </summary>
        [TestMethod, TestCategory("Yes/No Button")]
        public void YesNoTest()
        {
            try
            {
                _obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.YesNo, MgBtnStyle.Information,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        /// <summary>
        /// Defines the test method YesNoCancelTest.
        /// </summary>
        [TestMethod, TestCategory("Yes/No/Cancel Button")]
        public void YesNoCancelTest()
        {
            try
            {
                _obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.YesNoCancel, MgBtnStyle.Information,
                    "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Info");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        /// <summary>
        /// Defines the test method PassFailedPassedTest.
        /// </summary>
        [TestMethod, TestCategory("Pass/Failed Button")]
        public void PassFailedPassedTest()
        {
            var test = _obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.PassFailed, MgBtnStyle.Information,
                "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Info");
            TestContext.WriteLine($"RETURN VALUEL {test}");
            Assert.IsTrue(test.Equals(1));
        }
        /// <summary>
        /// Defines the test method PassFailedFailedTest.
        /// </summary>
        [TestMethod, TestCategory("Pass/Failed Button")]
        public void PassFailedFailedTest()
        {
            var test = _obj.DoMessage("It has been 7 days since your last backup. EXPECT FAILED TEST!", MgboxStyle.PassFailed, MgBtnStyle.Information,
                "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Info");
            TestContext.WriteLine($"RETURN VALUEL {test}");
            Assert.IsTrue(test.Equals(0));
        }
    }
}
