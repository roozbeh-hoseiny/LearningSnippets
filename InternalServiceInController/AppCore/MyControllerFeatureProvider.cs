using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Reflection;

namespace InternalServiceInController.AppCore;

internal sealed class MyControllerFeatureProvider : ControllerFeatureProvider
{
    protected override bool IsController(TypeInfo typeInfo)
    {
        var isCustomController = !typeInfo.IsAbstract && typeof(ControllerBase).IsAssignableFrom(typeInfo);
        return isCustomController || base.IsController(typeInfo);
    }
}