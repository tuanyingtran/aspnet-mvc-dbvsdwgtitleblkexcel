using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdimRic841PipingCharVV.Models
{
    public class FunctionalLocationWithDwgDataModel
    {
        [Key]
        public string LocationId { get; set; }

        public string Unit { get; set; }

        public string BusinesssArea { get; set; }

        public string ApiPipeClass { get; set; }
        public string DwgApiPipeClass { get; set; }

        public string RefineryPipeClass { get; set; }
        public string DwgRefineryPipeClass { get; set; }

        public string PipingMaterial { get; set; }
        public string DwgPipingMaterial { get; set; }

        //if true display two validating column side by side
        public bool IsValidateApi { get; set; } = false;
        public bool IsValidateRefineryPipeClass { get; set; } = false;
        public bool IsValidatePipingMaterial { get; set; } = false;

    }
}