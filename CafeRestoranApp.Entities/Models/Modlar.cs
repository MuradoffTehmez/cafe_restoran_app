using CafeRestoranApp.Entities.Interfaces;

namespace CafeRestoranApp.Entities.Models
{
    public class Modlar : IEntity
    {
        public int Id { get; set; }

        public int IstifadeciID { get; set; }

        public string FormName { get; set; }

        public string ControlName { get; set; }

        public string ControlCaption { get; set; }

    }
}
