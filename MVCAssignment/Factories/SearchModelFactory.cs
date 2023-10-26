using MVCAssignment.Enums;
using MVCAssignment.Models.Search;
using Libraries.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVCAssignment.Models.Request;
using Libraries.Domain;
using MVCAssignment.Models.Response;
using System.Data.SqlClient;
using System.Data.Entity;
using Libraries.Data;

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
        public List<UserResponseModel> PrepareSearchUsers(List<UserFilterRequest> data)
        {
            using (ApplicationContext dbContext = new ApplicationContext())
            {
                var parameters = new List<SqlParameter>();

                var userNameParam = new SqlParameter("UserName", DBNull.Value);
                var roleParam = new SqlParameter("Role", DBNull.Value);
                var fNameParam = new SqlParameter("FName", DBNull.Value);
                var lNameParam = new SqlParameter("LName", DBNull.Value);
                var empCodeParam = new SqlParameter("EmpCode", DBNull.Value);
                var departmentParam = new SqlParameter("Department", DBNull.Value);

                foreach (var filter in data)
                {
                    if (!string.IsNullOrEmpty(filter.Value))
                    {
                        switch (filter.FieldName)
                        {
                            case "UserName":
                                userNameParam = new SqlParameter("UserName", filter.Value);
                                break;
                            case "Role":
                                roleParam = new SqlParameter("Role", filter.Value);
                                break;
                            case "FName":
                                fNameParam = new SqlParameter("FName", filter.Value);
                                break;
                            case "LName":
                                lNameParam = new SqlParameter("LName", filter.Value);
                                break;
                            case "EmpCode":
                                empCodeParam = new SqlParameter("EmpCode", filter.Value);
                                break;
                            case "Department":
                                departmentParam = new SqlParameter("Department", filter.Value);
                                break;
                        }
                    }
                }

                parameters.Add(userNameParam);
                parameters.Add(roleParam);
                parameters.Add(fNameParam);
                parameters.Add(lNameParam);
                parameters.Add(empCodeParam);
                parameters.Add(departmentParam);

                var result = dbContext.Database.SqlQuery<UserResponseModel>("SearchUsers @UserName, @Role, @FName, @LName, @EmpCode, @Department", parameters.ToArray()).ToList();

                return result;
            }
        }
    }







}





