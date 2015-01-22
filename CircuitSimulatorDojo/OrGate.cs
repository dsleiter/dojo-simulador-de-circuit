
using System.Collections.Generic;

namespace CircuitSimulatorDojo {
    class OrGate {
        public OrGate() {
            In1 = new Wire();
            In2 = new Wire();
            Out = new OrConnector(In1, In2);
        }

        public IConnector In1 { get; private set; }
        public IConnector In2 { get; private set; }
        public IConnector Out { get; private set; }

        private class OrConnector : IConnector {
            private readonly IConnector _in1;
            private readonly IConnector _in2;

            public OrConnector(IConnector in1, IConnector in2) {
                _in1 = in1;
                _in2 = in2;
                _in1.ConnectTo(this);
                _in2.ConnectTo(this);
            }

            public bool Value {
                get { return _in1.Value || _in2.Value; }
                set {
                    foreach (var connector in _connectors) {
                        connector.Value = Value;
                    }
                }
            }

            private readonly List<IConnector> _connectors = new List<IConnector>();

            public void ConnectTo(IConnector connector) {
                _connectors.Add(connector);
                connector.Value = Value;
            }
        }
    }
}
