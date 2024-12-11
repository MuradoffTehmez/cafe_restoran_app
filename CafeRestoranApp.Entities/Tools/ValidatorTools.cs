using CafeRestoranApp.Entities.Interfaces;
using FluentValidation;
using System.Windows.Forms;

namespace CafeRestoranApp.Entities.Tools
{
    public class ValidatorTools
    {
        public static bool Validates(IValidator validator, IEntity entity)
        {
            bool result = true;
            ValidationContext<IEntity> context = new ValidationContext<IEntity>(entity);
            var validationResult = validator.Validate(context);

            if (!validationResult.IsValid)
            {
                string message = null;
                foreach (var error in validationResult.Errors)
                {
                    message += error.ErrorMessage + System.Environment.NewLine;
                }
                MessageBox.Show(message);
                result = false;
            }

            return result;
        }
    }
}
