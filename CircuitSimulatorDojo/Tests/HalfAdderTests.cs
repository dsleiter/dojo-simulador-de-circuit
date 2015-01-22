using NUnit.Framework;

namespace CircuitSimulatorDojo.Tests {
    class HalfAdderTests {
        [TestCase(false, false, ExpectedResult = false)]
        [TestCase(false, true, ExpectedResult = true)]
        [TestCase(true, false, ExpectedResult = true)]
        [TestCase(true, true, ExpectedResult = false)]
        public bool S_should_equal_sum(bool a, bool b) {
            var halfAdder = new HalfAdder();
            halfAdder.A.Value = a;
            halfAdder.B.Value = b;
            return halfAdder.S.Value;
        }

        [TestCase(false, false, ExpectedResult = false)]
        [TestCase(false, true, ExpectedResult = true)]
        [TestCase(true, false, ExpectedResult = true)]
        [TestCase(true, true, ExpectedResult = false)]
        public bool Input_deve_conectar_ao_fio(bool a, bool b) {
            var wireA = new Wire();
            var wireB = new Wire();
            var halfAdder = new HalfAdder();
            wireA.ConnectTo(halfAdder.A);
            wireB.ConnectTo(halfAdder.B);
            halfAdder.A.Value = a;
            halfAdder.B.Value = b;
            return halfAdder.S.Value;
        }
        
        [TestCase(false, false, ExpectedResult = false)]
        [TestCase(false, true, ExpectedResult = false)]
        [TestCase(true, false, ExpectedResult = false)]
        [TestCase(true, true, ExpectedResult = true)]
        public bool C_should_equal_carry(bool a, bool b) {
            var halfAdder = new HalfAdder();
            halfAdder.A.Value = a;
            halfAdder.B.Value = b;
            return halfAdder.C.Value;
        }

        [TestCase(false, false, ExpectedResult = false)]
        [TestCase(false, true, ExpectedResult = true)]
        [TestCase(true, false, ExpectedResult = true)]
        [TestCase(true, true, ExpectedResult = false)]
        public bool S_deve_conectar_ao_fio(bool a, bool b) {
            var halfAdder = new HalfAdder();
            var wire = new Wire();
            halfAdder.S.ConnectTo(wire);
            halfAdder.A.Value = a;
            halfAdder.B.Value = b;
            return wire.Value;
        }

        [TestCase(false, false, ExpectedResult = false)]
        [TestCase(false, true, ExpectedResult = false)]
        [TestCase(true, false, ExpectedResult = false)]
        [TestCase(true, true, ExpectedResult = true)]
        public bool C_deve_conectar_ao_fio(bool a, bool b) {
            var halfAdder = new HalfAdder();
            var wire = new Wire();
            halfAdder.C.ConnectTo(wire);
            halfAdder.A.Value = a;
            halfAdder.B.Value = b;
            return wire.Value;
        }
    }
}
