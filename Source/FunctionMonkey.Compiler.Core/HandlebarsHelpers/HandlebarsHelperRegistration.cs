﻿namespace FunctionMonkey.Compiler.Core.HandlebarsHelpers
{
    internal static class HandlebarsHelperRegistration
    {
        public static void RegisterHelpers()
        {
            AzureAuthenticationTypeHelper.Register();
            HttpVerbsHelper.Register();
            RouteParametersHelper.Register();
            MappedHeaderNameForPropertyHelper.Register();
            ParameterOutputBindingHelper.Register();
            CollectorOutputBindingHelper.Register();
            OutputBindingJsonHelper.Register();
        }
    }
}
