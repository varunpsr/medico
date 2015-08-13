using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIBase.Models
{
	public class UserData
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		[Required]
		public double Weight { get; set; }

		[Required]
		public int Height { get; set; }

		[Required]
		public Constants.Gender Gender { get; set; }

		[Required]
		public Constants.Built Built { get; set; }

		[Required]
		public string UserId { get; set; }

		[Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime CreatedDate { get; set; }

		[Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime ModifiedDate { get; set; }
	}
}
