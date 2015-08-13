using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIBase.Models
{
	public class BMIContext : DbContext
	{

		public BMIContext(): base("CompositionContext")
		{
			Database.SetInitializer<BMIContext>(new DropCreateDatabaseAlways<BMIContext>());
		}

		public DbSet<UserData> UserData { get; set; }

		public DbSet<BodyComposition> BodyComposition { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}

	}
}
