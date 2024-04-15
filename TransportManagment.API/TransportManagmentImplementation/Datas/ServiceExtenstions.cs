﻿
using Implementation.Interfaces.Authentication;
using Implementation.Services.Authentication;
using IntegratedImplementation.Interfaces.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagmentImplementation.Interfaces.Common;
using TransportManagmentImplementation.Interfaces.Configuration;
using TransportManagmentImplementation.Services.Common;
using TransportManagmentImplementation.Services.Configuration;

namespace TransportManagmentImplementation.Datas
{
    public static class ServiceExtenstions
    {
        public static IServiceCollection AddCoreBusiness(this IServiceCollection services)
        {
           
            #region User Service
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            #endregion

            #region Configuration
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IGeneralConfigService, GeneralConfigService>();
            #endregion

            #region Common
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IRegionService, RegionService>();
            services.AddScoped<IWoredaService, WoredaService>();
            services.AddScoped<IZoneService, ZoneService>();
            services.AddScoped<ICompanyProfileService, CompanyProfileService>();
            services.AddScoped<ICommonCodeService, CommonCodeService>();
            services.AddScoped<IDeviceListService, DeviceListService>();

            #endregion



            return services;
        }
    }
}
