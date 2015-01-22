namespace CircuitSimulatorDojo {
    public class Terminal : Gate {
        private readonly bool _value;

        public Terminal(bool value) {
            _value = value;
        }

        public override bool Out {
            get { return _value; }
        }
    }
}
