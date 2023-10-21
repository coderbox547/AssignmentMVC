using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVCAssignment.Models.Search
{
    public class SearchParametersModel
    {
        public SearchParametersModel()
        {
            AvailableControlType = new List<SelectListItem>();
            AvailableDataType = new List<SelectListItem>();
            AvailableUsers = new List<SelectListItem>();
            AvailableFieldNames= new List<SelectListItem>();
        }

        [Required]
        public int SelectedUser { get; set; }

        [JsonIgnore]
        public IList<SelectListItem> AvailableUsers { get; set; }

        [Required]
        public string FieldName { get; set; }


        [JsonIgnore]
        public IList<SelectListItem> AvailableFieldNames{ get; set; }

        [Required]
        public int SelectedFieldName { get; set; }


        [JsonIgnore]
        public IList<SelectListItem> AvailableDataType { get; set; }

        [Required]
        public int SelectedDataType { get; set; }



        [JsonIgnore]
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
