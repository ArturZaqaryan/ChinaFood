using ChinaFood.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ChinaFood.Domain
{
    public class DataManager(IDishesRepository dishesRepository)
    {
        public IDishesRepository DishesRepository { get; set; } = dishesRepository;

        public void GetSelectedTable(PropertyInfo table, out dynamic? selectedTable)
        {
            selectedTable = null;
            if (table != null && table.PropertyType == typeof(IDishesRepository))
            {
                var repository = table.GetValue(this) as IDishesRepository;
                if (repository != null)
                {
                    selectedTable = repository;
                }
            }
        }
    }
}
