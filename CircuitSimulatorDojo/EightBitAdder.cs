using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulatorDojo {
    class EightBitAdder {
        private readonly FullAdder[] _adders = new FullAdder[8];
        public EightBitAdder() {
            _adders[7] = new FullAdder();
            for (var n = 6; n >= 0; n--) {
                _adders[n] = new FullAdder();
                _adders[n].Carry.ConnectTo(_adders[n+1].C);
            }
        }

        public bool Overflow { get { return _adders[7].Carry.Value; } }

        private byte _a;
        public byte A {
            get { return _a; }
            set {
                _a = value;
                for (var n = 0; n < 8; n++) {
                    _adders[n].A.Value = (_a & (1 << n)) > 0;
                }
            }
        }

        private byte _b;
        public byte B {
            get { return _b; }
            set {
                _b = value;
                for (var n = 0; n < 8; n++) {
                    _adders[n].B.Value = (_b & (1 << n)) > 0;
                }
            }
        }

        public byte Sum {
            get {
                var sum = 0;
                for (var n = 0; n < 8; n++) {
                    sum |= _adders[n].Sum.Value ? 1 << n : 0;
                }
                return (byte)sum;
            }
        }
    }
}
