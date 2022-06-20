using RedisApp.Web.Model;
using RedisApp.Web.Services;

namespace InMemoryApp.Web.Services
{
    public class CategoryService : ICategoryService
    {
        static List<CategoryModel> categories => new()
    {
        new CategoryModel { Id = 1, Name = "Burger" },
        new CategoryModel { Id = 2, Name = "Pizza" }
    };

        public ICacheService CacheService { get; }

        public CategoryService(ICacheService cacheService)
        {
            CacheService = cacheService;
        }
        public List<CategoryModel> GetAllCategory()
        {
            return GetCategoriesFromCache();
        }
        private List<CategoryModel> GetCategoriesFromCache()
        {
            return CacheService.GetOrAdd("allcategories", () => { return categories; });
        }

        List<CategoryModel> ICategoryService.GetAllCategory()
        {
            throw new NotImplementedException();
        }
    }
}
