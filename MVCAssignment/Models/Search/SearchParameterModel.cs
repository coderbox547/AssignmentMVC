using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVCAssignment.Models.Search
{
    public class SearchParameterModel
    {
        public SearchParameterModel() {
        }

        //public string UserName { get; set; }

        public string FieldName { get; set; }

        public Enums.DataTypeEnum SelectedDataType { get; set; }

        public Enums.ControlTypeEnum SelectedControlType { get; set; }

        public string Required { get; set; }

        public int MaxFieldLength { get; set; }

        public double MinLimit { get; set; }

        public double MaxLimit { get; set; }

        public string MaskPattern { get; set; }
    }
}
