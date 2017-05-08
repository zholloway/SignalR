using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalR2.Models.ViewModels
{
    public class ChatroomVM
    {
        /*
         * This view model is used to avoid sending the UserID every time a ChatMessage is sent. 
         * We should only be showing the UserName
         */

        [Required]
        public string Content { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime TimeStamp { get; set; }

        //constructors
        public ChatroomVM() { }

        public ChatroomVM(ChatMessage message)
        {
            Content = message.Content;
            Author = message.User.UserName;
            TimeStamp = message.DateCreated;
        }
    }
}