using ChinaFood.Domain.Repositories.Abstract;
using System.Reflection;

namespace ChinaFood.Domain
{
    public class DataManager(IDishesRepository dishesRepository, ISubCategoriesRepository subCategoriesRepository)
    {
        public IDishesRepository Dishes { get; set; } = dishesRepository;
        public ISubCategoriesRepository SubCategories { get; set; } = subCategoriesRepository;

        public void GetSelectedTable(PropertyInfo table, out dynamic selectedTable)
        {
            selectedTable = null;
            if (table != null)
            {
                if(table.PropertyType == typeof(IDishesRepository))
                {
                    if (table.GetValue(this) is IDishesRepository repository)
                    {
                        selectedTable = repository;
                    }
                }
                if (table.PropertyType == typeof(ISubCategoriesRepository))
                {
                    if (table.GetValue(this) is ISubCategoriesRepository repository)
                    {
                        selectedTable = repository;
                    }
                }
            }
        }
    }
}
