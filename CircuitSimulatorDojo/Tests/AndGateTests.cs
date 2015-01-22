using NUnit.Framework;
using Should;

namespace CircuitSimulatorDojo.Tests {
    class AndGateTests {

        [TestCase(false, false)]
        [TestCase(false, true)]
        [TestCase(true, false)]
        [TestCase(true, true)]
        public void Out_should_be_and_of_In1_and_In2(bool in1, bool in2) {
            var andGate = new AndGate();
            andGate.In1.Value = in1;
            andGate.In2.Value = in2;
            andGate.Out.Value.ShouldEqual(in1 && in2);
        }

        [TestCase(false, false)]
        [TestCase(false, true)]
        [TestCase(true, false)]
        [TestCase(true, true)]
        public void Out_should_connect_to_wire(bool in1, bool in2) {
            var andGate = new AndGate();
            var wire = new Wire();
            andGate.Out.ConnectTo(wire);
            andGate.In1.Value = in1;
            andGate.In2.Value = in2;
            wire.Value.ShouldEqual(in1 && in2);
        }

        [TestCase(false, false)]
        [TestCase(false, true)]
        [TestCase(true, false)]
        [TestCase(true, true)]
        public void In1In2_should_receive_from_wire(bool in1, bool in2) {
            var wire1 = new Wire();
            var wire2 = new Wire();
            var andGate = new AndGate();
            wire1.ConnectTo(andGate.In1);
            wire2.ConnectTo(andGate.In2);
            wire1.Value = in1;
            wire2.Value = in2;
            andGate.Out.Value.ShouldEqual(in1 && in2);
        }
    }
}
