namespace HomeworkTests
{
    public class ChainTests
    {

        [Test]
        public void ChainStrings_ValidInput_ReturnsConnectedStrings()
        {
            string a = "szyszka";
            string b = "du¿a  a";

            string? resault = Homework.Chain.ChainStrings(a, b);

            Assert.That(resault, Is.Not.Null);
            Assert.That(resault, Is.EqualTo("szyszkadu¿a  a"));
        }

        [Test]
        public void ChainStrings_FirstParameterInvalid_ReturnsNull()
        {
            string a = "szyszka";
            string? b = null;

            string? resault1 = Homework.Chain.ChainStrings(a, b);

            Assert.That(resault1, Is.Null);
        }

        [Test]
        public void ChainStrings_SecondParameterInvalid_ReturnsNull()
        {
            string? a = null;
            string b = "aaaa";

            string? resault2 = Homework.Chain.ChainStrings(a, b);

            Assert.That(resault2, Is.Null);
        }

        [Test]
        public void ChainStrings_BothParametersInvalid_ReturnsNull()
        {
            string? a = null;
            string? b = null;

            string? resault = Homework.Chain.ChainStrings(a, b);

            Assert.That(resault, Is.Null);
        }
    }
}