namespace CircuitSimulatorDojo {
    class HalfAdder : Gate {
        private OrGate _or;
        private AndGate _and1;
        private AndGate _and2;
        private NotGate _not;

        public HalfAdder() {
            _or = new OrGate();
            _and1 = new AndGate();
            _and2 = new AndGate();
            _not = new NotGate();
        }

        public override bool Out {
            get {
                Compute();
                return _and2.Out;
            }
        }

        public bool Carry {
            get {
                Compute();
                return _and1.Out;
            }
        }

        private void Compute() {
            _not.InA = _and1;
            _and2.InA = _or;
            _and2.InB = _not;
            _or.InA = InA;
            _and1.InA = InA;
            _or.InB = InB;
            _and1.InB = InB;
        }
    }
}
