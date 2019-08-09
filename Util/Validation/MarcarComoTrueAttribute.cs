using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProAspNetCoreMvcValidation.Util.Validation
{
    [Route("api/[controller]")]
    public class MarcarComoTrueAttribute : Attribute, IModelValidator
    {
        public bool IsRequired => true;
        public string ErrorMessage { get; set; } = "Você deve marcar como true";
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            bool? value = context.Model as bool?;

            if (!value.HasValue || value.Value == false)
            {
                return new List<ModelValidationResult> { new ModelValidationResult("", ErrorMessage) };
            }
            else
            {
                return Enumerable.Empty<ModelValidationResult>();
            }
        }
    }
}
