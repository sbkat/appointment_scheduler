using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace event_scheduler.Models
{
    public class PublicEvent
    {
        [Key]
        public int EventId { get; set; }
        [Display (Name="Title: ")]
        [Required (ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        [Display (Name="Time: ")]
        [Required (ErrorMessage = "Enter a time.")]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
        [Display (Name="Date: ")]
        [Required (ErrorMessage = "Enter a date for this activity.")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Display (Name="Duration: ")]
        [Required (ErrorMessage = "Enter estimated duration of this activity.")]
        public int DurationInt { get; set; }
        [Display (Name="")]
        public string DurationTime { get; set; }
        [Display (Name="Description: ")]
        [Required (ErrorMessage = "Enter a short description.")]
        public string Description { get; set; }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public int UserId { get; set; }
        public User Creator { get; set; }
        public List<Participant> Participants { get; set; }
    }
}