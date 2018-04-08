using System;

namespace AquaticDroneUI.Models
{
    public class Clients
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string ContactPerson { get; set; }
        public string Opdrachten { get; set; }
        public int Status { get; set; }
    }
}