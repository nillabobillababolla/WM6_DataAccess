using System;

namespace CrudOdev.ViewModels
{
    public class ProductViewModel
    {
        // ReSharper disable once InconsistentNaming
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public override string ToString() => $"{ProductName}";

        public static explicit operator ProductViewModel(string v)
        {
            throw new NotImplementedException();
        }
    }
}
