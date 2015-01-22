
using NUnit.Framework;
using Should;

namespace CircuitSimulatorDojo.Tests {
    class AndGateTests {
        [TestCase(true, true, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, false)]
        [TestCase(false, false, false)]
        public void AndGate_should_work(bool inA, bool inB, bool result) {
            var and = new AndGate {
                InA = new Terminal(inA),
                InB = new Terminal(inB)
            };
            and.Out.ShouldEqual(result);
        }
    }
}
