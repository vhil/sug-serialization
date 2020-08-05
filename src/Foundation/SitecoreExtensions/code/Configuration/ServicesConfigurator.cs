namespace Sug.Foundation.SitecoreExtensions.Configuration
{
	using Microsoft.Extensions.DependencyInjection;
	using Sug.Foundation.SitecoreExtensions.Extensions;
	using Sitecore.DependencyInjection;

	public class ServicesConfigurator : IServicesConfigurator
	{
		public void Configure(IServiceCollection serviceCollection)
		{
			serviceCollection.AddMvcControllers(this.GetType().Assembly);
		}
	}
}