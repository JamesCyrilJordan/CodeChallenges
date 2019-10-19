using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreEntityPlayground.Database.Entities
{
	public class Achievement
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }
	}
}