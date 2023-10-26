using Libraries.Domain;
using MVCAssignment.Models.Request;
using MVCAssignment.Models.Response;
using MVCAssignment.Models.Search;
using System.Collections.Generic;

namespace MVCAssignment.Factories
{
    public interface ISearchModelFactory
    {
        void PrepareSearchParameterModel(SearchParametersModel model);
        //List<User> PrepareSearchUserModel(List<UserFilterRequest> data);
        List<UserResponseModel> PrepareSearchUsers(List<UserFilterRequest> data);
    }
}
