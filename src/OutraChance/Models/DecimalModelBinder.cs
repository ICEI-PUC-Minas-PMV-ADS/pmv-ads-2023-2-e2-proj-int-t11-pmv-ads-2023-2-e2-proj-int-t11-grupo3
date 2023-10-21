using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;

namespace OutraChance.Models
{
    public class DecimalModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            if (valueProviderResult == ValueProviderResult.None)
                return Task.CompletedTask;

            bindingContext.ModelState.SetModelValue(bindingContext.ModelName, valueProviderResult);

            var valueAsString = valueProviderResult.FirstValue;
            if (string.IsNullOrEmpty(valueAsString))
                return Task.CompletedTask;

            // Tente interpretar o valor tanto no formato da cultura atual quanto no formato invariável
            decimal result;
            if (decimal.TryParse(valueAsString, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out result) ||
                decimal.TryParse(valueAsString, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out result))
            {
                bindingContext.Result = ModelBindingResult.Success(result);
                return Task.CompletedTask;
            }

            // Se não foi possível interpretar, adicione um erro ao model state
            bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, "Valor decimal inválido.");
            return Task.CompletedTask;
        }
    }
}
