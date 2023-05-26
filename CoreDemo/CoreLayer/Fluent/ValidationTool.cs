using BusinessLayer.ValidationRule;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CoreLayer.Fluent
{
    public static class ValidationTool
    {
        public static void Validationtool(IValidator validator , object entity)
        {
            var context = new ValidationContext<object>(entity);
            var results = validator.Validate(context);

            if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {

                    throw new ValidationException(results.Errors);
                    
                    
                }
                
            }
        }

    }
}
