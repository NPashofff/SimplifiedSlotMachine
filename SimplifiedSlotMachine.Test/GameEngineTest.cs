using SimplifiedSlotMachine.Core;

namespace SimplifiedSlotMachine.Test
{
    public class GameEngineTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TripleATest()
        {
            var row = new List<char>()
            {
                'A',
                'A',
                'A'
            };
            var coefficient = GameEngine.CalculateWiningCoefficient(row);
            Assert.That(coefficient == 1.2m);
        }

        [Test]
        public void DoubleAAndWildCardTest()
        {
            var row = new List<char>()
            {
                'A',
                'A',
                '*'
            };
            var coefficient = GameEngine.CalculateWiningCoefficient(row);
            Assert.That(coefficient == 0.8m);
        }

        [Test]
        public void TripleWildCardTest()
        {
            var row = new List<char>()
            {
                '*',
                '*',
                '*'
            };
            var coefficient = GameEngine.CalculateWiningCoefficient(row);
            Assert.That(coefficient == 0m);
        }

        [Test]
        public void TripleBTest()
        {
            var row = new List<char>()
            {
                'B',
                'B',
                'B'
            };
            var coefficient = GameEngine.CalculateWiningCoefficient(row);
            Assert.That(coefficient == 1.8m);
        }

        [Test]
        public void TriplePTest()
        {
            var row = new List<char>()
            {
                'P',
                'P',
                'P'
            };
            var coefficient = GameEngine.CalculateWiningCoefficient(row);
            Assert.That(coefficient == 2.4m);
        }
    }
}
