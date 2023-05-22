using InspectionTaskApi.Models;
using Microsoft.EntityFrameworkCore;

namespace InspectionTaskApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<CopyRequestDto> CopyRequests => Set<CopyRequestDto>();
        public DbSet<Inspection> Inspections => Set<Inspection>();
        public DbSet<AssignedToPerson> AssignedToPersons => Set<AssignedToPerson>();     

    }
}
