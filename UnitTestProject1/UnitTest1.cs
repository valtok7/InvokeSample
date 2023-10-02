using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using System.Windows;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WindowsFormsApp2.Form1 myClass = new WindowsFormsApp2.Form1();
            MethodInfo methodInfo = typeof(WindowsFormsApp2.Form1).GetMethod("MyFunc", BindingFlags.NonPublic | BindingFlags.Instance);
            var parameters = new object[] { 100, null };
            bool result1 = (bool)methodInfo.Invoke(myClass, parameters);
            string result2 = (string)parameters[1];
            Console.WriteLine("result1: " + result1.ToString());
            Console.WriteLine("result2: " + result2);
        }
    }
}
