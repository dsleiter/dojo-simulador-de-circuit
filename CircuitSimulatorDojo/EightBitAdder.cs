
namespace CircuitSimulatorDojo {
    class EightBitAdder {

        FullAdder[] _adders = new FullAdder[8];

        public byte A { get; set; }
        public byte B { get; set; }
        public byte Sum { get; private set; }
        public bool Overflow { get; private set; }

        public EightBitAdder() {
            for (int i = 0; i < _adders.Length; i++) {
                _adders[i] = new FullAdder();
            }

        }

        private void Compute() {
            
        }

    }
}
