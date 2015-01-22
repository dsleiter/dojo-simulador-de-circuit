
namespace CircuitSimulatorDojo {
    public class Wire : Gate {
        public override bool Out {
            get { return InA.Out; }
        }
    }
}
