using System.Data.Entity.Validation;
using System.Linq;

namespace CrudOdev
{
    public class EntityHelper
    {
        public static string ValidationMessage(DbEntityValidationException ex)
        {
            // ReSharper disable once RedundantAssignment
            var result = ex.EntityValidationErrors.Aggregate(string.Empty, (accumulator2, validationErrors) => validationErrors.ValidationErrors.Aggregate(accumulator2, (accumulator, validationError) => accumulator += $"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}\n"));
            return result + "\n";
        }
    }
}
