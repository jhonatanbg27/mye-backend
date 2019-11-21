namespace MyE.Domain
{
    public class Order
    {
        public int OrderId {get;set;}
        public int Priority {get;set;}
        public DateTime Date {get;set;}

        public virtual int UserId{get;set;}
        public virtual int MedicalEquipamentId {get;set;}
    }
}