using NUnit.Framework;

namespace CircuitSimulatorDojo.Tests {
    class NotGateTest {
        [TestCase(true, false)]
        [TestCase(false, true)]
        public void NotGate_should_work(bool inA, bool result) {
            var g = new NotGate {
                InA = new Terminal(inA)
            };
            Assert.AreEqual(result, g.Out);
        }
    }
}
