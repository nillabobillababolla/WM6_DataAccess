namespace EF_TemelCrudIslemleri.ViewModels
{
   public class ProductViewModel
    {
        // ReSharper disable once InconsistentNaming
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }
        public override string ToString() => $"{ProductName} {UnitPrice:c2}";

    }
}
