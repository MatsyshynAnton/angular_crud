﻿using BusinessLogicLayer.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjectStructureHW.ExceptionsMiddleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        private Task HandleException(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            switch(exception)
            {
                case NotFoundException _:
                    {
                        context.Response.StatusCode = 404;
                        break;
                    }
                case NullEntityException _:
                    {
                        context.Response.StatusCode = 400;
                        break;
                    }
                case DbUpdateException _:
                    {
                        context.Response.StatusCode = 400;
                        break;
                    }
                default:
                    {
                        context.Response.StatusCode = 500;
                        break;
                    }
            }

            return context.Response.WriteAsync(exception.Message);
        }
    }
}
