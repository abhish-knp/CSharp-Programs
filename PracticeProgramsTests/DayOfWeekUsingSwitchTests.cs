using NuGet.Frameworks;
using NUnit.Framework;
using PracticePrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms.Tests
{
    [TestFixture()]
    public class DayOfWeekUsingSwitchTests
    {
        [Test()]
        public void GetDayTest()
        {
            var obj = new DayOfWeekUsingSwitch();
            string sunday = obj.GetDay(0);
            Assert.AreEqual("Sunday", sunday);
            string monday = obj.GetDay(1);
            Assert.AreEqual("Sunday", monday);
            //TODO: Write testcase to test all conditions possible for GetDay functions
            Assert.Fail();
        }
    }
}