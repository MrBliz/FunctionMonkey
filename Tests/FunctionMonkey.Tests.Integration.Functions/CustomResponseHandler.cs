﻿using System;
using System.Threading.Tasks;
using AzureFromTheTrenches.Commanding.Abstractions;
using FunctionMonkey.Abstractions.Http;
using FunctionMonkey.Commanding.Abstractions.Validation;
using Microsoft.AspNetCore.Mvc;

namespace FunctionMonkey.Tests.Integration.Functions
{
    public class CustomResponseHandler : IHttpResponseHandler
    {
        public Task<IActionResult> CreateResponseFromException<TCommand>(TCommand command, Exception ex) where TCommand : ICommand
        {
            return Task.FromResult((IActionResult)new OkObjectResult("CreateResponseFromException<TCommand>"));
        }

        // We can't use where TCommand : ICommand<TResult> due to the function injection - we can't bind the generic return type
        // (will revisit and check)
        public Task<IActionResult> CreateResponse<TCommand, TResult>(TCommand command, TResult result) where TCommand : ICommand
        {
            return Task.FromResult((IActionResult)new OkObjectResult("CreateResponse<TCommand,TResult>"));
        }

        public Task<IActionResult> CreateResponse<TCommand>(TCommand command)
        {
            return Task.FromResult((IActionResult)new OkObjectResult("CreateResponse<TCommand>"));
        }

        public Task<IActionResult> CreateValidationFailureResponse<TCommand>(TCommand command, ValidationResult validationResult) where TCommand : ICommand
        {
            return Task.FromResult((IActionResult)new OkObjectResult("CreateValidationFailureResponse<TCommand>"));
        }
    }
}
