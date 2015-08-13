using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIBase.Models
{
	public class BodyComposition
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		public double BMI { get; set; }

		public int MetabolicRate { get; set; }

		public double FatPercentage { get; set; }

		public double MuscleMass { get; set; }

		public double WaterPercentage { get; set; }

		public double BoneDensity { get; set; }

		public double FatWeight { get; set; }

		public double MusclePercentage { get; set; }

		public int BodyAge { get; set; }

		[Required]
		public string Userid { get; set; }

		[Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime CreatedDate { get; set; }

		[Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime ModifiedDate { get; set; }

		[Required]
		public DateTime MeasuredDate { get; set; }

	}
}
