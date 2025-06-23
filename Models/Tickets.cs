namespace HelpDesk.Models
{
    public class Tickets
    {
        public int SeverityId{get; set;}
        public int DepartmentId{get;set;}
        public int PersonnelId { get; set; }
        public string FirstName { get; set; }=string.Empty;
        public string LastName { get; set; }=string.Empty;
        public string Description { get; set; }=string.Empty;
        public string Subject { get; set; }= string.Empty;
        public int Id{get;set; }
    }
}
