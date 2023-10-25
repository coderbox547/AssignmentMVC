using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment.Models.Request
{
    public class Parameter
    {
        public Enums.FieldNameEnum FieldName { get; set; }

        public Enums.DataTypeEnum SelectedDataType { get; set; }

        public Enums.ControlTypeEnum SelectedControlType { get; set; }

        public string Required { get; set; }

        public int MaxFieldLength { get; set; }

        public double MinLimit { get; set; }

        public double MaxLimit { get; set; }

        public string MaskPattern { get; set; }
    }
}