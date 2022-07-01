using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BurnSoft.MsgBox.UnitTest
{
    [TestClass]
    public class MsgBoxTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MsgClass obj = new MsgClass();
            obj.DoMessage("It has been 7 days since your last backup.", MgboxStyle.Inf_OK, MgBtnStyle.mb_Exclamantion,
                "Last Backup Notice", AutoCloseTimer.ac_0Sec, true, "Warning");
        }
    }
}
