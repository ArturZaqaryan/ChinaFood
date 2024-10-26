using ChinaFood.Domain.Repositories.Abstract;
using System.Reflection;

namespace ChinaFood.Domain
{
    public class DataManager(IDishesRepository dishesRepository)
    {
        public IDishesRepository Dishes { get; set; } = dishesRepository;

        public void GetSelectedTable(PropertyInfo table, out dynamic selectedTable)
        {
            selectedTable = null;
            if (table != null && table.PropertyType == typeof(IDishesRepository))
            {
                if (table.GetValue(this) is IDishesRepository repository)
                {
                    selectedTable = repository;
                }
            }
        }
    }
}
