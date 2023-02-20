using System;
using System.ComponentModel.DataAnnotations;

namespace TodoLists.Models
{
	public class TodoItem
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="Açıklama gerekli !")]
		public string Description { get; set; }
		[Required(ErrorMessage ="Durum Belirtilmeli !")]
		public string Status { get; set; }

       
    }
}

