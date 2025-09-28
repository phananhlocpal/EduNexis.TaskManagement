using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Options;

namespace TaskManagement.Infrastructure.DataAcess
{
    public class AppDbContext : DbContext
    {
        private readonly MySettingsjjjjj _appsetting;

        public AppDbContext(DbContextOptions<AppDbContext> options, IOptions<MySettingsjjjjj> settings)
           : base(options)
        {
            _appsetting = settings.Value;
        }

        public DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_appsetting.SQLServerConfig.Connection);
        }    
    }
}
