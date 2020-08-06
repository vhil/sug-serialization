using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using Xwrap;
using Xwrap.FieldWrappers.Abstractions;
using Xwrap.Mvc.RenderingParameters;

#region /sitecore/templates/Feature/Metadata/_Metadata

namespace Sug.Feature.Metadata.SitecoreTemplates
{
	/// <summary>
	/// Item wrapper for items of template '_Metadata'.
	/// Template ID: {1F082A45-36F5-4DE1-988A-72AAC08BD330}.
	/// Template path: /sitecore/templates/Feature/Metadata/_Metadata.
	/// </summary>
	[TemplateId(Constants.TemplateIdString)]
    // ReSharper disable once InconsistentNaming
	// ReSharper disable once PartialTypeWithSinglePart
	public partial class _MetadataItem : ItemWrapper
	{
		public _MetadataItem(Item item) : base(item)
		{
		}

		/// <summary>
		/// A wrapped 'single-line text' field for item field with name: 'Meta title'.
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper MetaTitle => this.WrapField<ITextFieldWrapper>(FieldNames.MetaTitle);

		public static class Constants
		{
			public static readonly TemplateID TemplateId = new TemplateID(new ID(TemplateIdString));
			public const string TemplateIdString = "{1F082A45-36F5-4DE1-988A-72AAC08BD330}"; 
		}

		public static class FieldNames
		{
			public const string MetaTitle = "Meta title"; 
		}

		public static class FieldIds
		{
			public static ID MetaTitle = new ID("{AB300DB7-3D19-4E2F-BF52-4BF0B892ABC2}"); 
		}
	}
}

#endregion
