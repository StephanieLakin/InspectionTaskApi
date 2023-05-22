using InspectionTaskApi.Models;
using System.Collections.Generic;

namespace InspectionTaskApi.Models
{
    public class CopyRequestDto
    {
        public int Id { get; set; }
        public int CopyInspectionId { get; set; }        
        public int AssignedToPersonId { get; set; }
      
    }
}


