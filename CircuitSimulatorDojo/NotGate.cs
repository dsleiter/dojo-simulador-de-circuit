using System;
using System.Collections.Generic;

namespace CircuitSimulatorDojo {
    public class NotGate {
        public NotGate() {
            In = new InnerConnector {
                GetFunc = () => _inValue,
                SetFunc = v => {
                    _inValue = v;
                    Out.Value = !_inValue;
                }
            };
            Out = new InnerConnector {
                GetFunc = () => !_inValue,
                SetFunc = v => { }
            };
            _inValue = false;
        }
        public IConnector In { get; private set; }
        public IConnector Out { get; private set; }

        private bool _inValue;

        private class InnerConnector : IConnector {
            public bool Value {
                get { return GetFunc(); }
                set {
                    SetFunc(value);
                    foreach (var connector in _connectors) {
                        connector.Value = Value;
                    }
                }
            }

            public Func<bool> GetFunc = () => false;
            public Action<bool> SetFunc = v => { }; 

            private readonly List<IConnector> _connectors = new List<IConnector>();
            public void ConnectTo(IConnector connector) {
                _connectors.Add(connector);
                connector.Value = Value;
            }
        }
    }
}