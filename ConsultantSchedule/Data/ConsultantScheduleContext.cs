#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsultantSchedule.Models
{
    public class ConsultantScheduleContext : DbContext
    {
        public ConsultantScheduleContext (DbContextOptions<ConsultantScheduleContext> options)
            : base(options)
        {
        }

        public DbSet<ConsultantSchedule.Models.Consultant> Consultant { get; set; }
    }
}
