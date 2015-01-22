using System.Linq;
using NUnit.Framework;
using Should;

namespace CircuitSimulatorDojo.Tests {
    [TestFixture]
    internal class WireTests {

        [TestCase(true)]
        [TestCase(false)]
        public void Deve_ter_como_definir_value(bool valueDesejado) {
            var wire = new Wire();
            wire.Value = valueDesejado;
            wire.Value.ShouldEqual(valueDesejado);
        }

        [TestCase(true, 1)]
        [TestCase(false, 1)]
        [TestCase(true, 4)]
        [TestCase(false, 6)]
        public void Deve_conectar_ao_outro_wires(bool valueDesejado, int numWires) {
            var wire = new Wire();
            var outroWires = Enumerable.Repeat(0, numWires).Select(_ => new Wire()).ToList();
            outroWires.ForEach(wire.ConnectTo);
            wire.Value = valueDesejado;
            outroWires.ForEach(w => w.Value.ShouldEqual(valueDesejado));
        }
    }
}