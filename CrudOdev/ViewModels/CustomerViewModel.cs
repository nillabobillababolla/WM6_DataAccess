namespace CrudOdev.ViewModels
{
   public class CustomerViewModel
    {
        // ReSharper disable once InconsistentNaming
        public string CustomerID { get; set; }

        public string ContactName { get; set; }

        public string CompanyName { get; set; }
        public override string ToString() => $"{ContactName} - {CompanyName}";
    }
}
