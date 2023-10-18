using System;

namespace Full_GRASP_And_SOLID
{
    public class CatalogCreator
    {
        public Product CreateProduct(string description, double unitCost)
        {
            return new Product(description, unitCost);
        }

        public Equipment CreateEquipment(string description, double hourlyCost)
        {
            return new Equipment(description, hourlyCost);
        }
    }
}