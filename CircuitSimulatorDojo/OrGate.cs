
namespace CircuitSimulatorDojo {
    class OrGate : Gate {
        public override bool Out {
            get { return InA.Out || InB.Out; }
        }
    }
}
