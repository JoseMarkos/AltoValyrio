namespace Alto_Valyrio.src.Inventory.Products.Applications.CreateCategory
{
    public class ProductCategoryCommandHandler
    {
        private readonly ProductCategoryCreator Creator;

        public ProductCategoryCommandHandler(ProductCategoryCreator creator)
        {
            Creator = creator;
        }

        public void Trigger(ProductCategoryCommand command)
        {
            Creator.Create(command.GetName);
        }
    }
}
