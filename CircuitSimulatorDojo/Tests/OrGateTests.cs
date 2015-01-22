using NUnit.Framework;
using Should;

namespace CircuitSimulatorDojo.Tests {
    class OrGateTests {
        [TestCase(true, true, true)]
        [TestCase(true, false, true)]
        [TestCase(false, true, true)]
        [TestCase(false, false, false)]
        public void OrGate_should_work(bool inA, bool inB, bool result) {
            var or = new OrGate {
                InA = new Terminal(inA),
                InB = new Terminal(inB)
            };
            
            or.Out.ShouldEqual(result);
        }
    }
}
