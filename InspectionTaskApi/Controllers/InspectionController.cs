using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InspectionTaskApi.Data;
using InspectionTaskApi.Models;
using System.Reflection.Metadata.Ecma335;

namespace InspectionTaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspectionController : ControllerBase
    {
        private readonly DataContext _context;

        public InspectionController(DataContext context)
        {
            _context = context;
        }

        // GET: api/inspection
        [HttpGet]
        public async Task<ActionResult<List<Inspection>>> GetInspections()
        {    // Retrieve the list of inspections along with associated assigned persons
            return Ok(await _context.Inspections.Include(i => i.AssignedToPerson).ToListAsync());
        }


        // POST: api/inspection/copy accepts a CopyRequestDto object in the request body.

        [HttpPost("Copy")]
        public async Task<ActionResult> Copy([FromBody] CopyRequestDto copyRequestDto)
        {
            try
            {       // searching for the inspection to copy based on the CopyInspectionId provided in the request.
                var inspection = await _context.Inspections.FirstOrDefaultAsync(i => i.Id == copyRequestDto.CopyInspectionId);
                if (inspection == null)
                {
                    return NotFound("Copy request denied; inspection not found.");
                }
                // searching for the assigned person based on the AssignedToPersonId provided in the request.
                var person = await _context.AssignedToPersons.FirstOrDefaultAsync(i => i.Id == copyRequestDto.AssignedToPersonId);
                if (person == null)
                {
                    return NotFound("Copy request denied; Assignee not found.");
                }
                // creates a new CopyRequestDto object with the CopyInspectionId and AssignedToPersonId from the request.
                var copyToInsert = new CopyRequestDto
                {
                    CopyInspectionId = copyRequestDto.CopyInspectionId,
                    AssignedToPersonId = copyRequestDto.AssignedToPersonId,

                };
                // Add the copy request to the data context and save changes
                _context.CopyRequests.Add(copyToInsert);
                await _context.SaveChangesAsync();

                return Ok("Copy request Saved Successfully");

            }
            catch (Exception ex)
            {

                return StatusCode(500, "An error occured while saving the copy request.");
            }

        }

        // GET: api/inspection/requests
        [HttpGet("Requests")]
        public async Task<ActionResult<List<CopyRequestDto>>> GetRequests()
        {
            var requests = await _context.CopyRequests.ToListAsync();
            return Ok(requests);
        }
    }
}
