
namespace CircuitSimulatorDojo {
    public class NotGate : Gate {
        public override bool Out {
            get { return !InA.Out; }
        }
    }
}