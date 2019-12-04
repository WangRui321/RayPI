﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using RayPI.Infrastructure.Security.Interface;

namespace RayPI.Infrastructure.Security.Services
{
    public class RoleEvents : IRoleEventsHadner
    {
        public async Task Start(HttpContext httpContext)
        {
            await Task.CompletedTask;
        }

        public void TokenEbnormal(object eventsInfo)
        {

        }


        public void TokenIssued(object eventsInfo)
        {

        }


        public void NoPermissions(object eventsInfo)
        {

        }

        public void Success(object eventsInfo)
        {

        }


        public async Task End(HttpContext httpContext)
        {
            await Task.CompletedTask;
        }
    }
}
