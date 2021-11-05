using Microsoft.EntityFrameworkCore;
using SkillboxHW21.Models;

namespace SkillboxHW21.Data
{
    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public ContactContext(){}
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
