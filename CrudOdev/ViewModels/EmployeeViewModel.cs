namespace CrudOdev.ViewModels
{
   public class EmployeeViewModel
    {
        // ReSharper disable once InconsistentNaming
        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";
    }
}
