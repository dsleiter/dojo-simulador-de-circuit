namespace CircuitSimulatorDojo {
    class AndGate : Gate {
        public override bool Out {
            get { return InA.Out && InB.Out; }
        }
    }
}
