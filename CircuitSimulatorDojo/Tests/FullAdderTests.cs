
using NUnit.Framework;
using Should;

namespace CircuitSimulatorDojo.Tests {
    class FullAdderTests {

        [TestCase(false, false, false, false, false)]
        [TestCase(false, false, true, true, false)]
        [TestCase(false, true, false, true, false)]
        [TestCase(false, true, true, false, true)]
        [TestCase(true, false, false, true, false)]
        [TestCase(true, false, true, false, true)]
        [TestCase(true, true, false, false, true)]
        [TestCase(true,  true, true, true, true)]
        public void FullAdder_deve_funcionar_certo(bool inA, bool inB, bool inC, bool resultado, bool carry) {
            var fullAdder = new FullAdder() {
                InA = new Terminal(inA),
                InB = new Terminal(inB),
                InC = new Terminal(inC)
            };
            fullAdder.Out.ShouldEqual(resultado);
            fullAdder.Carry.ShouldEqual(carry);
        }

    }
}
