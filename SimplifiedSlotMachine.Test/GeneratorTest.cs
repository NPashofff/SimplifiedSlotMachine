using SimplifiedSlotMachine.Core;

namespace SimplifiedSlotMachine.Test
{
    public class GeneratorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RowCountTest()
        {
           var row =  Generator.GenerateRow();
            Assert.That(row.Count == 3);
        }

        [Test]
        public void NotNullTest()
        {
            var row = Generator.GenerateRow();
            Assert.That(row is not null);
        }
    }
}