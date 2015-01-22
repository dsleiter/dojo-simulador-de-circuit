using NUnit.Framework;
using Should;

namespace CircuitSimulatorDojo.Tests {
    internal class NotGateTest {

        [TestCase(true)]
        [TestCase(false)]
        public void Out_should_be_opposite_in(bool valDesejado) {
            var not = new NotGate();
            not.In.Value = valDesejado;
            not.Out.Value.ShouldEqual(!valDesejado);
        }

        [TestCase(true)]
        [TestCase(false)]
        public void Deve_connectar_ao_fio(bool valDesejado) {
            var not = new NotGate();
            var wire = new Wire();
            not.Out.ConnectTo(wire);
            not.In.Value = valDesejado;
            wire.Value.ShouldEqual(!valDesejado);
        }

        [TestCase(true)]
        [TestCase(false)]
        public void Deve_receber_de_fio(bool valDesejado) {
            var wire = new Wire();
            var not = new NotGate();
            wire.ConnectTo(not.In);
            wire.Value = valDesejado;
            not.Out.Value.ShouldEqual(!valDesejado);
        }
    }
}
