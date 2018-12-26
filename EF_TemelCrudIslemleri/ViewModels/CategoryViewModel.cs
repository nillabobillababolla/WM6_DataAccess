namespace EF_TemelCrudIslemleri.ViewModels
{
    public class CategoryViewModel
    {
        // ReSharper disable once InconsistentNaming
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ProductCount { get; set; }
        public override string ToString() => $"{CategoryName} - ({ProductCount})";
    }
}
