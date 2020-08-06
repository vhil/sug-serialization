namespace Sug.Feature.Navigation.Configuration
{
	using Sug.Foundation.SitecoreExtensions.Extensions;
	using Microsoft.Extensions.DependencyInjection;
	using Sitecore.DependencyInjection;
	
	public class ServicesConfigurator : IServicesConfigurator
	{
		public void Configure(IServiceCollection serviceCollection)
		{
			serviceCollection.AddMvcControllers(this.GetType().Assembly);
		}
	}
}