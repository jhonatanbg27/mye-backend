namespace Hospital.Entity
{
    public class Machinereview
    {
        public int Id{get;set;}
        public string Reviewdate {get;set;}
        public int Idschedule{get;set;}

        public Schedule Schedule{get;set;}

        
    }
}