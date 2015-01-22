
using NUnit.Framework;
using Should;

namespace CircuitSimulatorDojo.Tests {
    internal class WireTests {
        [TestCase(true)]
        [TestCase(false)]
        public void Out_deve_ter_o_mesmo_valor_como_In(bool inValor) {
            var wire = new Wire();
            //wire.In = inValor;
            //wire.Out.ShouldEqual(wire.In);
        }
    }
}