
using System;
using System.Management.Instrumentation;
using System.Net.Configuration;
using NUnit.Framework;
using Should;

namespace CircuitSimulatorDojo.Tests {
    class HalfAdderTests {

        [TestCase(false, false, false, false)]
        [TestCase(false, true, true, false)]
        [TestCase(true, false, true, false)]
        [TestCase(true, true, false, true)]
        public void HalfAdder_deve_funcionar_certo(bool inA, bool inB, bool resultado, bool carry) {
            var halfAdder = new HalfAdder {
                InA = new Terminal(inA),
                InB = new Terminal(inB)
            };
            halfAdder.Out.ShouldEqual(resultado);
            halfAdder.Carry.ShouldEqual(carry);
        }

        
    }
}
