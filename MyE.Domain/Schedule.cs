namespace MyE.Domain
{
    public class Schedule
    {
        public int Id {get;set;}
        public DateTime AgreedDate {get;set;}
        public DateTime ArrivalDate {get;set;}
        public int EngineerId {get;set;}
        public int AdministratorId {get;set;}

        public virtual int OrderId {get;set;}

        public virtual int UserId {get;set;}
    }
}