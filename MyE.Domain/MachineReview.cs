namespace MyE.Domain
{
    public class MachineReview
    {
        public int Id {get;set;}
        public int EngineerId {get;set;}

        public DateTime ReviewDate {get;set;}
        public DateTime ReturnDate {get;set;}
        public long MedicalEquipamentPhoto {get;set;}
        public int OrderId{get;set;}
        public virtual int UserId {get;set;}
    }
}