using System.Collections.Generic;

namespace CircuitSimulatorDojo {
    public class Wire : IConnector {
        private bool _value;
        private readonly List<IConnector> _connectors = new List<IConnector>();
        public bool Value {
            get { return _value; }
            set {
                _value = value;
                foreach (var connector in _connectors) {
                    connector.Value = _value;
                }
            }
        }

        public void ConnectTo(IConnector connector) {
            _connectors.Add(connector);
            connector.Value = _value;
        }
    }
}


