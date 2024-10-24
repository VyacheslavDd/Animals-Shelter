﻿using Core.Constants;

namespace AnimalsShelterBackend.Startups
{
	public static class CORSStartup
	{
		public static IServiceCollection AppendCors(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddCors(setup =>
			{
				setup.AddPolicy(Const.FrontendCORS, config =>
				{
					config.WithOrigins(configuration[Const.FrontendLink]).AllowAnyMethod().AllowAnyHeader();
				});
			});
			return services;
		}
	}
}
