using ChinaFood.Domain.Entities;
using ChinaFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IDishesRepository
    {
        Dish GetDishByID(Guid id);
        void AddDish(Dish dish);
        void RemoveDish(Guid id);
    }
}
