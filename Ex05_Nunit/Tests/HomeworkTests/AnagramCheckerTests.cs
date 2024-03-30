using Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTests
{
    public class AnagramCheckerTests
    {
        private Homework.IAnagramChecker _checker;
        
        [SetUp]
        public void Setup()
        {
            _checker = new Homework.AnagramChecker();
        }

        [Test]
        public void IsAnagram_ValidAnagrams_ReturnsTrue()
        {
            string a = "aaabbcc12";
            string b = "1a2bccbaa";
            
            bool result = _checker.IsAnagram(a, b);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsAnagram_SameWord_ReturnsTrue()
        {
            string a = "szyszka";
            string b = "szyszka";

            bool result = _checker.IsAnagram(a, b);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsAnagram_DifferentLength_ReturnsFalse()
        {
            string a = "szyszka";
            string b = "szysz";

            bool result = _checker.IsAnagram(a, b);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsAnagram_IgnoreNonAlphanumericCharacters_ReturnsTrue()
        {
            string a = "aaa!;bbcc#12";
            string b = "1a2b!@#cc;b{aa";

            bool result = _checker.IsAnagram(a, b);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsAnagram_CaseInsensitive_ReturnsTrue()
        {
            string a = "aaaBBcc12";
            string b = "1a2bcCbaA";

            bool result = _checker.IsAnagram(a, b);

            Assert.IsTrue(result);
        }

        [Test]
        public void IsAnagram_FirstArgNull_ReturnsFalse()
        {
            string? a = null;
            string b = "szyszka";

            bool result = _checker.IsAnagram(a, b);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsAnagram_SecondArgNull_ReturnsFalse()
        {
            string a = "szyszka";
            string? b = null;

            bool result = _checker.IsAnagram(a, b);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsAnagram_AllArgsNull_ReturnsFalse()
        {
            string? a = null;
            string? b = null;

            bool result = _checker.IsAnagram(a, b);

            Assert.IsFalse(result);
        }


        [Test]
        public void IsAnagram_EmptyWords_ReturnsTrue()
        {
            string a = "";
            string b = "";

            bool result = _checker.IsAnagram(a, b);

            Assert.IsTrue(result);
        }

        //* dopisane po napisaniu kodu *//
        [Test]
        public void IsAnagram_AllNonAlphanumeric_ReturnsTrue()
        {
            string a = "!@#!@#!@#!@#%";
            string b = "<:>:?{}$#%*&";

            bool result = _checker.IsAnagram(a, b);

            Assert.IsTrue(result);
        }

    }
}
