using SimplifiedSlotMachine.Core;

namespace SimplifiedSlotMachine.Test
{
    public class Tests
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
    }
}