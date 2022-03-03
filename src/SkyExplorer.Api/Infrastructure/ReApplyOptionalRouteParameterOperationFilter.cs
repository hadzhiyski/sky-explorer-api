using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SkyExplorer.Api.Infrastructure;

// ReSharper disable once ClassNeverInstantiated.Global
public class ReApplyOptionalRouteParameterOperationFilter : IOperationFilter
{
    private const string CaptureName = "routeParameter";
    private const string TemplateRegex = $"{{(?<{CaptureName}>\\w*:*\\w*)\\?}}";

    private const string SendEmptyDescription =
        "Must check \"Send empty value\" or Swagger passes a comma for empty values otherwise";

    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        var httpMethodAttributeTemplates = context.MethodInfo
            .GetCustomAttributes(true)
            .OfType<HttpMethodAttribute>()
            .Where(attr => attr.Template?.Contains('?') ?? false)
            .Select(attr => attr.Template)
            .ToList();
        var routeAttributeTemplates = context.MethodInfo
            .GetCustomAttributes(true)
            .OfType<RouteAttribute>()
            .Where(attr => attr.Template?.Contains('?') ?? false)
            .Select(attr => attr.Template)
            .ToList();

        var templates = httpMethodAttributeTemplates.Concat(routeAttributeTemplates);
        var targetTemplate = templates.FirstOrDefault();

        if (targetTemplate == null)
        {
            return;
        }

        var matches = Regex.Matches(targetTemplate, TemplateRegex);

        foreach (Match match in matches)
        {
            var name = match.Groups[CaptureName].Value.Split(':').First();

            var parameter = operation.Parameters.FirstOrDefault(p => p.In == ParameterLocation.Path && p.Name == name);
            if (parameter == null)
            {
                continue;
            }

            parameter.AllowEmptyValue = true;
            parameter.Description = string.IsNullOrWhiteSpace(parameter.Description)
                ? SendEmptyDescription
                : $"{parameter.Description}\\{SendEmptyDescription}";
            parameter.Required = false;
            //parameter.Schema.Default = new OpenApiString(string.Empty);
            parameter.Schema.Nullable = true;
        }
    }
}