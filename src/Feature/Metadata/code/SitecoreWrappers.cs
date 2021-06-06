// Auto-generated xWrap item wrappers for Feature.Metadata configuration
using global::Sitecore.Data;
using global::Sitecore.Data.Items;
using global::Sitecore.Mvc.Presentation;
using global::System.CodeDom.Compiler;
using global::Xwrap;
using global::Xwrap.FieldWrappers.Abstractions;
using global::Xwrap.Mvc.RenderingParameters;

#region /sitecore/templates/Feature/Metadata/_Metadata

namespace Feature.Metadata.SitecoreTemplates
{
    /// <summary>
	/// Item wrapper for items of template '_Metadata'.
	/// Template ID: {1F082A45-36F5-4DE1-988A-72AAC08BD330}.
	/// Template path: /sitecore/templates/Feature/Metadata/_Metadata.
	/// </summary>
	[GeneratedCode("Leprechaun", "2.0.1")]
    [TemplateId(Constants.TemplateIdString)]
    // ReSharper disable once InconsistentNaming
	// ReSharper disable once PartialTypeWithSinglePart
	public partial class _MetadataItem : ItemWrapper
	{
		public _MetadataItem(Item item) : base(item)
		{
		}

		public static class Constants
		{
			public static readonly TemplateID TemplateId = new TemplateID(new ID(TemplateIdString));
			public const string TemplateIdString = "{1F082A45-36F5-4DE1-988A-72AAC08BD330}"; 
		}
		
		/// <summary>
		/// A wrapped "Single-Line Text" field for item field with name: "Meta description".
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper MetaDescription => this.WrapField<ITextFieldWrapper>(FieldNames.MetaDescription);
		
		/// <summary>
		/// A wrapped "Single-Line Text" field for item field with name: "Meta title".
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper MetaTitle => this.WrapField<ITextFieldWrapper>(FieldNames.MetaTitle);
		
		public struct FieldNames
		{
			public const string MetaDescription = "Meta description";
			public const string MetaTitle = "Meta title";
		}

		public struct FieldIds
		{
			public static ID MetaDescription => new ID("{E83AF5C1-D134-4FEC-82F2-1254A3424F95}");
			public static ID MetaTitle => new ID("{AB300DB7-3D19-4E2F-BF52-4BF0B892ABC2}");
		}
	}
}

#endregion


