// Auto-generated xWrap item wrappers for Feature.Navigation configuration
using global::Sitecore.Data;
using global::Sitecore.Data.Items;
using global::Sitecore.Mvc.Presentation;
using global::System.CodeDom.Compiler;
using global::Xwrap;
using global::Xwrap.FieldWrappers.Abstractions;
using global::Xwrap.Mvc.RenderingParameters;

#region /sitecore/templates/Feature/Navigation/Data/_Navigation

namespace Feature.Navigation.SitecoreTemplates
{
    /// <summary>
	/// Item wrapper for items of template '_Navigation'.
	/// Template ID: {0F8C46C4-E777-46D0-89E0-225972998022}.
	/// Template path: /sitecore/templates/Feature/Navigation/Data/_Navigation.
	/// </summary>
	[GeneratedCode("Leprechaun", "2.0.1")]
    [TemplateId(Constants.TemplateIdString)]
    // ReSharper disable once InconsistentNaming
	// ReSharper disable once PartialTypeWithSinglePart
	public partial class _NavigationItem : ItemWrapper
	{
		public _NavigationItem(Item item) : base(item)
		{
		}

		public static class Constants
		{
			public static readonly TemplateID TemplateId = new TemplateID(new ID(TemplateIdString));
			public const string TemplateIdString = "{0F8C46C4-E777-46D0-89E0-225972998022}"; 
		}
		
		/// <summary>
		/// A wrapped "Single-Line Text" field for item field with name: "Navigation title".
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper NavigationTitle => this.WrapField<ITextFieldWrapper>(FieldNames.NavigationTitle);
		
		/// <summary>
		/// A wrapped "Checkbox" field for item field with name: "Show in breadcrumbs".
		/// <returns><see cref="ICheckboxFieldWrapper"/></returns>
		/// </summary>
		public ICheckboxFieldWrapper ShowInBreadcrumbs => this.WrapField<ICheckboxFieldWrapper>(FieldNames.ShowInBreadcrumbs);
		
		/// <summary>
		/// A wrapped "Checkbox" field for item field with name: "Show in navigation".
		/// <returns><see cref="ICheckboxFieldWrapper"/></returns>
		/// </summary>
		public ICheckboxFieldWrapper ShowInNavigation => this.WrapField<ICheckboxFieldWrapper>(FieldNames.ShowInNavigation);
		
		public struct FieldNames
		{
			public const string NavigationTitle = "Navigation title";
			public const string ShowInBreadcrumbs = "Show in breadcrumbs";
			public const string ShowInNavigation = "Show in navigation";
		}

		public struct FieldIds
		{
			public static ID NavigationTitle => new ID("{CA349367-5B39-4F87-8A6C-AD8B987191D9}");
			public static ID ShowInBreadcrumbs => new ID("{9376BCCA-6D11-4506-A601-E75AA509AFD3}");
			public static ID ShowInNavigation => new ID("{FFE61CDC-6969-4040-B801-E988695C16A0}");
		}
	}
}

#endregion


