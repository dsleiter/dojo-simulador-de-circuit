using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CircuitSimulatorDojo.Tests {
    class FullAdderTests {
        [TestCase(false, false, false, ExpectedResult = false)]
        [TestCase(false, false, true, ExpectedResult = true)]
        [TestCase(false, true, false, ExpectedResult = true)]
        [TestCase(false, true, true, ExpectedResult = false)]
        [TestCase(true, false, false, ExpectedResult = true)]
        [TestCase(true, false, true, ExpectedResult = false)]
        [TestCase(true, true, false, ExpectedResult = false)]
        [TestCase(true, true, true, ExpectedResult = true)]
        public bool Sum_should_equal_sum(bool a, bool b, bool c) {
            var fullAdder = new FullAdder();
            fullAdder.A.Value = a;
            fullAdder.B.Value = b;
            fullAdder.C.Value = c;
            return fullAdder.Sum.Value;
        }
    }
}
