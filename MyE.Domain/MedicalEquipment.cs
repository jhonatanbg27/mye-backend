
using System.Collections.Generic;

namespace MyE.Domain
{
    public class MedicalEquipment
    {
        public int Id {get;set;}
        public string StateDescription {get;set;}
        public string Brand {get;set;}
        public string Name {get;set;}
        public virtual ICollection<Order> Orders { get; set; }

    }
}