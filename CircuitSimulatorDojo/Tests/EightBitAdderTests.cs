using NUnit.Framework;

namespace CircuitSimulatorDojo.Tests {
    class EightBitAdderTests {
        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(10, 20, ExpectedResult = 30)]
        [TestCase(128, 127, ExpectedResult = 255)]
        public byte Sum_deve_compute_certo(byte a, byte b) {
            var adder = new EightBitAdder();
            adder.A = a;
            adder.B = b;
            return adder.Sum;
        }

        [TestCase(1, 2, ExpectedResult = false)]
        [TestCase(128, 127, ExpectedResult = false)]
        [TestCase(254, 1, ExpectedResult = false)]
        [TestCase(128, 128, ExpectedResult = true)]
        [TestCase(248, 15, ExpectedResult = true)]
        public bool Overflow_deve_funcionar(byte a, byte b) {
            var adder = new EightBitAdder();
            adder.A = a;
            adder.B = b;
            return adder.Overflow;
        }
    }
}
