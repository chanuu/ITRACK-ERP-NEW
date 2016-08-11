using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace XtraSchedulerEFTest
{
    #region #efappointment
   public class EFAppointment
    {
        [Key]
        public int UniqueID {get;set;}
        [Required]
        public int Type {get;set;}
        [Required]
        public DateTime StartDate {get;set;}
        [Required]
        public DateTime EndDate {get;set;}
        public bool AllDay {get;set;}
        public string StyleID {get;set;}
        public string StyleNo {get;set;}
        public string Description { get; set; }
        public int Status {get;set;}
        public int Label {get;set;}
        public string ResourceIDs {get;set;}
        public string ReminderInfo {get;set;}
        public string RecurrenceInfo {get;set;}
    }
    #endregion #efappointment
}
