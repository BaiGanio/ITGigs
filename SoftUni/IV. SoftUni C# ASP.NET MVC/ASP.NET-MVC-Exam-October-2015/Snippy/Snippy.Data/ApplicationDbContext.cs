using Microsoft.AspNet.Identity.EntityFramework;
using Snippy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Snippy.Data.Migrations;

namespace Snippy.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Snippet> Snippets
        {
            get;
            set;
        }
        public IDbSet<Language> Languages
        {
            get;
            set;
        }
        public IDbSet<Label> Labels
        {
            get;
            set;
        }
        public IDbSet<Comment> Comments
        {
            get;
            set;
        }


    }
}
