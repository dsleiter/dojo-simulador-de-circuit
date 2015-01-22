using NUnit.Framework;
using Should;

namespace CircuitSimulatorDojo.Tests {
    class OrGateTests {

        [TestCase(false, false)]
        [TestCase(false, true)]
        [TestCase(true, false)]
        [TestCase(true, true)]
        public void Out_should_be_or_of_In1_and_In2(bool in1, bool in2) {
            var orGate = new OrGate();
            orGate.In1.Value = in1;
            orGate.In2.Value = in2;
            orGate.Out.Value.ShouldEqual(in1 || in2);
        }

        [TestCase(false, false)]
        [TestCase(false, true)]
        [TestCase(true, false)]
        [TestCase(true, true)]
        public void Out_should_connect_to_wire(bool in1, bool in2) {
            var orGate = new OrGate();
            var wire = new Wire();
            orGate.Out.ConnectTo(wire);
            orGate.In1.Value = in1;
            orGate.In2.Value = in2;
            wire.Value.ShouldEqual(in1 || in2);
        }

        [TestCase(false, false)]
        [TestCase(false, true)]
        [TestCase(true, false)]
        [TestCase(true, true)]
        public void In1In2_should_receive_from_wire(bool in1, bool in2) {
            var wire1 = new Wire();
            var wire2 = new Wire();
            var orGate = new OrGate();
            wire1.ConnectTo(orGate.In1);
            wire2.ConnectTo(orGate.In2);
            wire1.Value = in1;
            wire2.Value = in2;
            orGate.Out.Value.ShouldEqual(in1 || in2);
        }
    }
}
