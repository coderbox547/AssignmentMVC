using MVCAssignment.Enums;
using MVCAssignment.Models.Search;
using Libraries.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCAssignment.Factories
{
    public class SearchModelFactory : ISearchModelFactory
    {
        private readonly IUserService _userService;
        public SearchModelFactory(IUserService userService)
        {
            _userService = userService;
        }

        public void PrepareSearchParameterModel(SearchParametersModel model)
        {
            IEnumerable<DataTypeEnum> dataTypeEnumValues = Enum.GetValues(typeof(DataTypeEnum)).Cast<DataTypeEnum>();
            var dataTypes = from dataType in dataTypeEnumValues
                            select new SelectListItem() { Text = dataType.ToString(), Value = ((int)dataType).ToString() };

            model.AvailableDataType = dataTypes.ToList();

            IEnumerable<ControlTypeEnum> controlTypeEnumValues = Enum.GetValues(typeof(ControlTypeEnum)).Cast<ControlTypeEnum>();
            var controlTypes = from controlType in controlTypeEnumValues
                               select new SelectListItem() { Text = controlType.ToString(), Value = ((int)controlType).ToString() };

            model.AvailableControlType = controlTypes.ToList();


            IEnumerable<FieldNameEnum> fieldNameEnumValues = Enum.GetValues(typeof(FieldNameEnum)).Cast<FieldNameEnum>();
            var fieldNames = from fieldName in fieldNameEnumValues
                             select new SelectListItem() { Text = fieldName.ToString(), Value = ((int)fieldName).ToString() };

            model.AvailableFieldNames = fieldNames.ToList();


            var allUsers = _userService.GetAllUsers().Where(z => z.UserId==1).Select(u => new SelectListItem
            {
                Text = u.UserName,
                Value = u.UserId.ToString()
            });

            model.AvailableUsers = allUsers.ToList();

        }
    }
}
