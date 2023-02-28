namespace Simple_Invoicing.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string? ProjectName { get; set; }
        public string? ProjectDescription { get; set; }
        public string? ProjectContactName { get; set; }
        public string? ProjectContactEmail { get; set; }
        public string? ProjectContactPhone { get; set; }
        public string? ProjectNotes { get; set; }

    }

    public class Tasks
    {
        public int Id { get; set; }
        public string? TaskDescription { get; set;}
        public string? TaskNumber { get; set; }
    }
}
