using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Newtonsoft.Json;


namespace MVCA.Models
{
    public class timesheet
    {
        [Required]
        [Display(Name = "id")]
        public string  id
        {
            get;
            set;
        }

        [Required]
        [Display(Name = "task")]
        public string task
        {
            get;
            set;
        }
        [Display(Name = "time")]
        public decimal time
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "personname")]
        public string personname
        {
            get;
            set;
        }
    }
}