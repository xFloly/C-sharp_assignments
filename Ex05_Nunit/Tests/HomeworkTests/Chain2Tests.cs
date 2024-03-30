using Homework;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;

namespace HomeworkTests
{
    public class Chain2Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ChainStrings_ValidInput_ReturnsConnectedStrings()
        {
            string a = "szyszka";
            string b = "duża  a";
            try
            {
                string resault = Homework.Chain2.ChainStrings(a, b);

                Assert.That(resault, Is.Not.Null);
                Assert.That(resault, Is.EqualTo("szyszkaduża  a"));
            }
            catch (Exception ex) {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void ChainStrings_FirstParameterInvalid_ThrowsArgumentNullException()
        {
            string a = "szyszka";
            string? b = null;

            Assert.Throws<ArgumentNullException>(() => Chain2.ChainStrings(a, b));
        }

        [Test]
        public void ChainStrings_SecondParameterInvalid_ThrowsArgumentNullException()
        {
            string? a = null;
            string b = "aaaa";

            Assert.Throws<ArgumentNullException>(() => Chain2.ChainStrings(a, b));
        }

        [Test]
        public void Chain2Strings_BothParametersInvalid_ThrowsArgumentNullException()
        {
            string? a = null;
            string? b = null;

            Assert.Throws<ArgumentNullException>(() => Chain2.ChainStrings(a, b));
        }
    }
}
