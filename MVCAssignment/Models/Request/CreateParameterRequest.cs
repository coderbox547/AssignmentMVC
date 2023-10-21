using MVCAssignment.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment.Models.Request
{
    public class CreateParameterRequest
    {
        public int UserId { get; set; }
        public List<ParameterModel> Parameters { get; set; }
    }

    public class ParameterModel
    {
        public string FieldName { get; set; }

        public Enums.DataTypeEnum SelectedDataType { get; set; }

        public Enums.ControlTypeEnum SelectedControlType { get; set; }

        public bool IsRequired { get; set; }

        public int MaxFieldLength { get; set; }

        public double MinLimit { get; set; }

        public double MaxLimit { get; set; }

        public string MaskPattern { get; set; }
    }
}