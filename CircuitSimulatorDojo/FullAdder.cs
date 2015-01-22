
namespace CircuitSimulatorDojo {
    public class FullAdder : Gate {

        private HalfAdder _halfAdder1;
        private HalfAdder _halfAdder2;
        private OrGate _or;

        public FullAdder() {
            _halfAdder1 = new HalfAdder();
            _halfAdder2 = new HalfAdder();
            _or = new OrGate();
        }

        public override bool Out {
            get {
                Compute();
                return _halfAdder2.Out;
            }
        }

        public bool Carry {
            get {
                Compute();
                return _or.Out;
            }
        }

        public Gate InC { get; set; }

        private void Compute() {
            _halfAdder2.InA = _halfAdder1;
            _halfAdder2.InB = InC;
            _halfAdder1.InA = InA;
            _halfAdder1.InB = InB;
            _or.InA = new Terminal(_halfAdder2.Carry);
            _or.InB = new Terminal(_halfAdder1.Carry);
        }
    }
}
