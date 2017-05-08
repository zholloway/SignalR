using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SignalR2.Models
{
    public class ChatMessage
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        [ForeignKey("User")]
        public string UserID { get; set; }

        public ApplicationUser User { get; set; }
    }
}