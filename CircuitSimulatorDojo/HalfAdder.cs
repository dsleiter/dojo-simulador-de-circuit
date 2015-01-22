
namespace CircuitSimulatorDojo {
    class HalfAdder {
        public HalfAdder() {
            A = new Wire();
            B = new Wire();
            _and1 = new AndGate();
            _and2 = new AndGate();
            _or1 = new OrGate();
            _not1 = new NotGate();

            A.ConnectTo(_and1.In1);
            A.ConnectTo(_or1.In1);
            B.ConnectTo(_and1.In2);
            B.ConnectTo(_or1.In2);

            _or1.Out.ConnectTo(_and2.In1);
            _and1.Out.ConnectTo(_not1.In);
            _not1.Out.ConnectTo(_and2.In2);
        }

        private readonly AndGate _and1;
        private readonly AndGate _and2;
        private readonly OrGate _or1;
        private readonly NotGate _not1;

        public IConnector A { get; private set; }
        public IConnector B { get; private set; }

        public IConnector S {
            get { return _and2.Out; }
        }

        public IConnector C {
            get { return _and1.Out; }
        }
    }
}
