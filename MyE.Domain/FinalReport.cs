using System;

namespace MyE.Domain
{
    public class FinalReport
    {
        public int Id {get;set;}
        public string Description {get;set;}
        public DateTime ReportDate {get;set;}
        public virtual int MembershipId {get;set;}

    }
}