namespace InspectionTaskApi.Models
{
    public class Inspection
    {
        public int Id { get; set; }
        public string? Name { get; set; }           
        public string? Location { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;

        //Foreign Key
        public int AssignedToPersonId { get; set; }
        public AssignedToPerson? AssignedToPerson { get; set; }
    }
}
