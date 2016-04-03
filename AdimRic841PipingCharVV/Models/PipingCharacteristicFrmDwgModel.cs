using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdimRic841PipingCharVV.Models
{
    public class PipingCharacteristicFrmDwgModel
    {
        [Key]
        public string LocationId { get; set; }
        public string ApiPipeClass { get; set; }
        public string RefineryPipeClass { get; set; }
        public string PipingMaterial { get; set; }
    }
}