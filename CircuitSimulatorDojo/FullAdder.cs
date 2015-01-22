using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulatorDojo {
    class FullAdder {
        private readonly HalfAdder _half1;
        private readonly HalfAdder _half2;
        private readonly OrGate _or1;

        public FullAdder() {
            _half1 = new HalfAdder();
            _half2 = new HalfAdder();
            _or1 = new OrGate();

            _half1.S.ConnectTo(_half2.A);
            _half1.C.ConnectTo(_or1.In2);
            _half2.C.ConnectTo(_or1.In1);
        }

        public IConnector A {
            get { return _half1.A; }
        }

        public IConnector B {
            get { return _half1.B; }
        }

        public IConnector C {
            get { return _half2.B; }
        }

        public IConnector Sum {
            get { return _half2.S; }
        }

        public IConnector Carry {
            get { return _or1.Out; }
        }
    }
}
