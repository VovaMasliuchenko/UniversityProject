﻿using BLL.Services;
using EvenToTheMoon_EF_.BLL.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Registration
{
    public static class ServicesRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IReviewService, ReviewService>()
       ;
    }
}
