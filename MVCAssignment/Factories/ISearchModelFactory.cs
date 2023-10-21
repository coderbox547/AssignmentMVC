using MVCAssignment.Models.Search;

namespace MVCAssignment.Factories
{
    public interface ISearchModelFactory
    {
        void PrepareSearchParameterModel(SearchParametersModel model);
    }
}
