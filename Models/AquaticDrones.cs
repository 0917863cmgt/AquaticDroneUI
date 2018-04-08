using System;

namespace AquaticDroneUI.Models
{
    public class AquaticDrones
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Client { get; set; }
        public string Task { get; set; }
        public int Progression { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Date { get; set; }
        public int BatteryLevel { get; set; }
        public int EngineUsage { get; set; }
        public int SignalStrength { get; set; }
        public string Weather { get; set; }
        public string DataTransfer { get; set; }
        public string GPS { get; set; }
    }
}