using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulatorDojo {
    public abstract class Gate {
        public virtual Gate InA { get; set; }
        public virtual Gate InB { get; set; }
        public abstract bool Out { get; }
    }
}
