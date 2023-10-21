using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVCAssignment.Models.Search
{
    public class SearchParametersModel
    {
        public SearchParametersModel() {
            AvailableControlType = new List<SelectListItem>();
            AvailableDataType = new List<SelectListItem>();
        }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string FieldName { get; set; }

        public IList<SelectListItem> AvailableDataType { get; set; }

        [Required]
        public int SelectedDataType { get; set; }
        public IList<SelectListItem> AvailableControlType { get; set; }

        [Required]
        public int SelectedControlType { get; set; }

        [Required]
        public bool IsRequired { get; set; }

        public int MaxFieldLength { get; set; }

        public int MinLimit { get; set; }

        public int MaxLimit { get; set; }

        public string MaskPattern { get; set; }
    }
}
