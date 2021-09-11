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
    public class GuessingGameUsingWhileLoopTests
    {
        [Test()]
        public void GuessTest()
        {
            //TODO: Update Guess function code to pass below test.
            var obj = new GuessingGameUsingWhileLoop();

            List<string> data1 = new List<string> { "csharp" };
            List<string> data2 = new List<string> { "csharp2", "csharp" };
            List<string> data3 = new List<string> { "csharp2", "csharp23", "fd", "dd", "ff", "ff" };

            Assert.True(obj.Guess(data1));
            Assert.True(obj.Guess(data2));
            Assert.False(obj.Guess(data3));
        }
    }
}