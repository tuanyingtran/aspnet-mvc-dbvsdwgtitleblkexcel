using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdimRic841PipingCharVV.Models
{
    public class FunctionalLocationModel
    {
        [Key]
        [Display(Name = "Location Id")]
        [Required(ErrorMessage = "Location Id is required")]
        public string LocationId { get; set; }

        [Display(Name = "Unit")]
        [Required(ErrorMessage = "Unit is required")]
        [StringLength(4,MinimumLength = 4, ErrorMessage = "Unit must be {1} digits")]
        public string Unit { get; set; }

        [Display(Name = "Business Area")]
        public string BusinesssArea { get; set; }

        [Display(Name = "Api Pipe Class")]
        [Required(ErrorMessage = "Please provide Api Pipe Class")]
        public string ApiPipeClass { get; set; }

        [Display(Name = "Refinery Pipe Class")]
        public string RefineryPipeClass { get; set; }

        [Display(Name = "Pipe Material")]
        [Required(ErrorMessage = "Piping Material must be filled in")]
        public string PipingMaterial { get; set; }


    }
}