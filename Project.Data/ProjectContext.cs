using Microsoft.EntityFrameworkCore;
using Project.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options)
            :base(options)
        {
            Database.Migrate();
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }

    }
}
