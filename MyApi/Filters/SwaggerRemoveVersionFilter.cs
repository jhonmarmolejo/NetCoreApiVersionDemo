using System.Linq;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MyApi.Filters
{
    public class SwaggerRemoveVersionFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var versionParameter = operation.Parameters.FirstOrDefault(p => p.Name == "version");

            if (versionParameter != null)
            {
                operation.Parameters.Remove(versionParameter);
            }

        }
    }
}