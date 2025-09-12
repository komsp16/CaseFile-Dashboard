using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Core.Entities;

namespace Domain.Infrastructure.Data
{
    public class WorkCentreContext : DbContext
    {
        public WorkCentreContext(DbContextOptions<WorkCentreContext> options) : base(options)
        { 
        }
        public DbSet<VCaseInfo> vCaseInfos { get; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
