using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest
{
    public class Demo
    {
        [Test]
        public static void TestIf4ISeven()
        {
            int leftOver = 4 % 2;
            Assert.AreEqual(0, leftOver, "4 is not even !");
        }
        [Test]
        public static void TestNowIs19()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(19, currentTime.Hour, "Dabar ne 19 h");
        }

        [Test]
        public static void TestIf995ISEven()
        {
            int leftOver = 995 % 3;
            Assert.AreEqual(0, leftOver, "995 nesidalija 3 ");
        }
        [Test]
        public static void TestIfTodayIsMonday()
        {
            DateTime currentDay = DateTime.Now;
            Assert.AreEqual(DayOfWeek.Monday, currentDay.DayOfWeek, "Siandien ne pirmadienis");
        }
        [Test]
        public static void W85Sec()
        {
            Thread.Sleep(5000);
            

        }

    }
}
