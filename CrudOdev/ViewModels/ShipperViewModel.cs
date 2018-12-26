namespace CrudOdev.ViewModels
{
   public class ShipperViewModel
    {
        // ReSharper disable once InconsistentNaming
        public int ShipperID { get; set; }

        public string CompanyName { get; set; }
        
        public override string ToString() => $"{CompanyName}";
    }
}
