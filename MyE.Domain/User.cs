using System;
using System.Collections.Generic;
using System.Text;

namespace MyE.Domain
{
    public class User
    {
        public int IdUser { get; set; }
        public int IdRole { get; set; }
        public string Name { get; set; }
        public string Tipodoc { get; set; }
        public string Numdoc { get; set; }
        public string Addrress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Condition { get; set; }
        public Role Role { get; set; }

        /*public ICollection<Ingreso> ingresos{get;set;}*/
    }
}
