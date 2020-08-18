// ReSharper Disable all
using global::Sitecore.Data;
using global::Sitecore.Data.Fields;
using global::Sitecore.Data.Items;
using global::System.CodeDom.Compiler;

namespace Sug.Feature.Navigation.Data
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface INavigationItem
	{
		TextField NavigationTitleField { get; }
		CheckboxField ShowInBreadcrumbsField { get; }
		CheckboxField ShowInNavigationField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class Navigation : CustomItem, INavigationItem
	{
		public Navigation(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "_Navigation";
		public static ID ItemTemplateId => new ID("{0F8C46C4-E777-46D0-89E0-225972998022}");
		
		public TextField NavigationTitleField => new TextField(InnerItem.Fields[FieldConstants.NavigationTitle.Id]);
		public CheckboxField ShowInBreadcrumbsField => new CheckboxField(InnerItem.Fields[FieldConstants.ShowInBreadcrumbs.Id]);
		public CheckboxField ShowInNavigationField => new CheckboxField(InnerItem.Fields[FieldConstants.ShowInNavigation.Id]);
		public static implicit operator Navigation(Item item) => item != null ? new Navigation(item) : null;
		public static implicit operator Item(Navigation customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct NavigationTitle
            {
		        public const string FieldName = "Navigation title";
		        public static readonly ID Id = new ID("{CA349367-5B39-4F87-8A6C-AD8B987191D9}");
            }
            public struct ShowInBreadcrumbs
            {
		        public const string FieldName = "Show in breadcrumbs";
		        public static readonly ID Id = new ID("{9376BCCA-6D11-4506-A601-E75AA509AFD3}");
            }
            public struct ShowInNavigation
            {
		        public const string FieldName = "Show in navigation";
		        public static readonly ID Id = new ID("{FFE61CDC-6969-4040-B801-E988695C16A0}");
            }
            
		}
	}
}


