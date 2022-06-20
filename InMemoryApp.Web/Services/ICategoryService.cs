using RedisApp.Web.Model;

namespace RedisApp.Web.Services
{
    public interface ICategoryService
    {
        List<CategoryModel> GetAllCategory();
    }
}
