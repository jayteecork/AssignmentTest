using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AssignmentTest.Models
{
    public class Info
    {

        public int InfoID { get; set; }
        public int StudentID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date_Of_Birth { get; set; }
        [Display(Name = "Fees Owed (€)")]
        public double feesOwed { get; set; }

        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual Student Student { get; set; }

    }
}