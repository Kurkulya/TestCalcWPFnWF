﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Finders;
using System.Windows.Automation;

namespace TestCalcWPFnWF
{
    [TestClass]
    public class TestWFCalc
    {
        Window window = null;
        OM obj;
        [TestInitialize]
        public void StartUp()
        {
            string appPath = @"E:\C# 1708\Calcs\With Buttons\CalcWFwithButtons\CalcWFwithButtons\bin\Debug\CalcWFwithButtons";
            Application application = Application.Launch(appPath);
            window = application.GetWindow("Calc", InitializeOption.NoCache);
            obj = new OM(window);
        }

        [TestCleanup]
        public void TearDown()
        {
            window.Close();
        }

        [DataTestMethod]
        [DataRow("but1")]
        [DataRow("but2")]
        [DataRow("but3")]
        [DataRow("but4")]
        [DataRow("but5")]
        [DataRow("but6")]
        [DataRow("but6")]
        [DataRow("but8")]
        [DataRow("but9")]
        [DataRow("but0")]
        [DataRow("butMinus")]
        [DataRow("butPlus")]
        [DataRow("butMult")]
        [DataRow("butDiv")]
        [DataRow("butEqual")]
        public void TestWPFExistingElement(string elId)
        {
            Assert.AreEqual(true, obj.GetButton(elId).Visible);
        }

        [DataTestMethod]
        [DataRow("but1", "1")]
        [DataRow("but2", "2")]
        [DataRow("but3", "3")]
        [DataRow("but4", "4")]
        [DataRow("but5", "5")]
        [DataRow("but6", "6")]
        [DataRow("but7", "7")]
        [DataRow("but8", "8")]
        [DataRow("but9", "9")]
        [DataRow("but0", "0")]
        public void TestWPFSimpleCheck(string elId, string res)
        {
            obj.GetButton(elId).Click();
            string calc = obj.GetTextBox("txtResult").BulkText;
            Assert.AreEqual(res, calc);
        }

        [DataTestMethod]
        [DataRow(new string[] { "but1", "but2", "but3" }, "123")]
        [DataRow(new string[] { "but4", "but5", "but6" }, "456")]
        [DataRow(new string[] { "but7", "but8", "but9" }, "789")]
        [DataRow(new string[] { "but3", "but0", "but6" }, "306")]
        public void TestWPFComplexCheck(string[] arr, string res)
        {
            foreach (string str in arr)
            {
                obj.GetButton(str).Click();
            }
            string calc = obj.GetTextBox("txtResult").BulkText;
            Assert.AreEqual(res, calc);
        }

        [DataTestMethod]
        [DataRow("but1", "but2", "butPlus", "3")]
        [DataRow("but3", "but4", "butMinus", "-1")]
        [DataRow("but5", "but6", "butMult", "30")]
        [DataRow("but9", "but3", "butDiv", "3")]
        public void TestWPFRealJob(string x, string y, string op, string res)
        {
            obj.GetButton(x).Click();
            obj.GetButton(op).Click();
            obj.GetButton(y).Click();
            obj.GetButton("butEqual").Click();
            string calc = obj.GetTextBox("txtResult").BulkText;
            Assert.AreEqual(res, calc);
        }
    }
}
