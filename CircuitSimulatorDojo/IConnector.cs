namespace CircuitSimulatorDojo {
    public interface IConnector {
        bool Value { get; set; }
        void ConnectTo(IConnector connector);
    }
}