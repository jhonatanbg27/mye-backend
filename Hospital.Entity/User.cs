

namespace Hospital.Entity
{
    public class User
    {
        public int Id { get; set; }        
        public string Name { get; set; }
         public int Idrol { get; set; }
        public string Tipodoc { get; set; }
        public string Numdoc { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }   
        public string Passwordhash { get; set; }
     
        public string Passwordsalt { get; set; }
    
        public Role Role{get;set;}
      
    
    }
}