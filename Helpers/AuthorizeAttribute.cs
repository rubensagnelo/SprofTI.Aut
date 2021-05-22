using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using WebApi.Entities;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeAttribute : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var user = (User)context.HttpContext.Items["usuarioautenticado"];
        if (user == null)
        {
            // not logged in
            context.Result = new JsonResult(new { message = "não autorizado" }) { StatusCode = StatusCodes.Status401Unauthorized };
        }
    }
}