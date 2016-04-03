using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdimRic841PipingCharVV.Models
{
    public class DwgCmMergeData
    {
        public IList<PipingCharacteristicFrmDwgModel> DwgDataList { get; set; }
        public IList<FunctionalLocationModel> CmDataList { get; set; }
    }
}