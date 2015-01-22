using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Should;

namespace CircuitSimulatorDojo.Tests {
    public class TerminalTests {
        [TestCase(true)]
        [TestCase(false)]
        public void Terminal_out_deve_entregar_valor_passado_no_ctor(bool value) {
            var target = new Terminal(value);
            target.Out.ShouldEqual(value);
        }
    }
}
