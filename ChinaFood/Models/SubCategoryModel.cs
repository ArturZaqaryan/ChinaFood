using ChinaFood.Domain.Entities;

namespace ChinaFood.Models;

public class SubCategoryModel : BaseModel
{
    public DishType DishType { get; set; }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        if(obj == null) return false;

        if(obj is not SubCategoryModel) return false;

        return ((SubCategoryModel)obj).Id.Equals(this.Id);
    }
}
