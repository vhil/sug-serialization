// Auto-generated xWrap item wrappers for Foundation.SitecoreExtensions configuration
using global::Sitecore.Data;
using global::Sitecore.Data.Items;
using global::Sitecore.Mvc.Presentation;
using global::System.CodeDom.Compiler;
using global::Xwrap;
using global::Xwrap.FieldWrappers.Abstractions;
using global::Xwrap.Mvc.RenderingParameters;

#region /sitecore/templates/Foundation/SitecoreExtensions/Data/Test parameters template

namespace Foundation.SitecoreExtensions.SitecoreTemplates
{
	/// <summary>
	/// Rendering parameters wrapper for template 'Test parameters template'.
	/// Template ID: {CB56320C-774A-4508-926F-4300E36C627C}.
	/// Template path: /sitecore/templates/Foundation/SitecoreExtensions/Data/Test parameters template.
	/// </summary>
	[GeneratedCode("Leprechaun", "2.0.1")]
	public partial class TestParametersTemplate : RenderingParametersWrapper
	{
		public TestParametersTemplate(RenderingParameters parameters) : base(parameters)
		{
		}
		
		/// <summary>
		/// A wrapped "Checkbox" parameter for field with name "Checkbox field".
		/// <returns><see cref="ICheckboxFieldWrapper"/></returns>
		/// </summary>
		public ICheckboxFieldWrapper CheckboxField => this.CheckboxField(FieldNames.CheckboxField);
		
		/// <summary>
		/// A wrapped "Droplink" parameter for field with name "Droplink field".
		/// <returns><see cref="ILinkFieldWrapper"/></returns>
		/// </summary>
		public ILinkFieldWrapper DroplinkField => this.LinkField(FieldNames.DroplinkField);
		
		/// <summary>
		/// A wrapped "Integer" parameter for field with name "Integer field".
		/// <returns><see cref="IIntegerFieldWrapper"/></returns>
		/// </summary>
		public IIntegerFieldWrapper IntegerField => this.IntegerField(FieldNames.IntegerField);
		
		/// <summary>
		/// A wrapped "Internal Link" parameter for field with name "Internal link field".
		/// <returns><see cref="IInternalLinkFieldWrapper"/></returns>
		/// </summary>
		public IInternalLinkFieldWrapper InternalLinkField => this.InternalLinkField(FieldNames.InternalLinkField);
		
		/// <summary>
		/// A wrapped "Multilist" parameter for field with name "Multilist field".
		/// <returns><see cref="IListFieldWrapper"/></returns>
		/// </summary>
		public IListFieldWrapper MultilistField => this.ListField(FieldNames.MultilistField);
		
		/// <summary>
		/// A wrapped "Number" parameter for field with name "Number field".
		/// <returns><see cref="INumberFieldWrapper"/></returns>
		/// </summary>
		public INumberFieldWrapper NumberField => this.NumberField(FieldNames.NumberField);
		
		/// <summary>
		/// A wrapped "Single-Line Text" parameter for field with name "Single line text field".
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper SingleLineTextField => this.TextField(FieldNames.SingleLineTextField);
		
		public struct FieldNames
		{
			public const string CheckboxField = "Checkbox field";
			public const string DroplinkField = "Droplink field";
			public const string IntegerField = "Integer field";
			public const string InternalLinkField = "Internal link field";
			public const string MultilistField = "Multilist field";
			public const string NumberField = "Number field";
			public const string SingleLineTextField = "Single line text field";
		}
	}
}

#endregion

#region /sitecore/templates/Foundation/SitecoreExtensions/Data/Test template

namespace Foundation.SitecoreExtensions.SitecoreTemplates
{
    /// <summary>
	/// Item wrapper for items of template 'Test template'.
	/// Template ID: {8FFD86E6-F507-42C0-9B4B-8E9A0F782F46}.
	/// Template path: /sitecore/templates/Foundation/SitecoreExtensions/Data/Test template.
	/// </summary>
	[GeneratedCode("Leprechaun", "2.0.1")]
    [TemplateId(Constants.TemplateIdString)]
    // ReSharper disable once InconsistentNaming
	// ReSharper disable once PartialTypeWithSinglePart
	public partial class TestTemplateItem : ItemWrapper
	{
		public TestTemplateItem(Item item) : base(item)
		{
		}

		public static class Constants
		{
			public static readonly TemplateID TemplateId = new TemplateID(new ID(TemplateIdString));
			public const string TemplateIdString = "{8FFD86E6-F507-42C0-9B4B-8E9A0F782F46}"; 
		}
		
		/// <summary>
		/// A wrapped "Checkbox" field for item field with name: "Checkbox field".
		/// <returns><see cref="ICheckboxFieldWrapper"/></returns>
		/// </summary>
		public ICheckboxFieldWrapper CheckboxField => this.WrapField<ICheckboxFieldWrapper>(FieldNames.CheckboxField);
		
		/// <summary>
		/// A wrapped "Checklist" field for item field with name: "Checklist field".
		/// <returns><see cref="IListFieldWrapper"/></returns>
		/// </summary>
		public IListFieldWrapper ChecklistField => this.WrapField<IListFieldWrapper>(FieldNames.ChecklistField);
		
		/// <summary>
		/// A wrapped "Date" field for item field with name: "Date field".
		/// <returns><see cref="IDateTimeFieldWrapper"/></returns>
		/// </summary>
		public IDateTimeFieldWrapper DateField => this.WrapField<IDateTimeFieldWrapper>(FieldNames.DateField);
		
		/// <summary>
		/// A wrapped "Datetime" field for item field with name: "Date time field".
		/// <returns><see cref="IDateTimeFieldWrapper"/></returns>
		/// </summary>
		public IDateTimeFieldWrapper DateTimeField => this.WrapField<IDateTimeFieldWrapper>(FieldNames.DateTimeField);
		
		/// <summary>
		/// A wrapped "Droplink" field for item field with name: "Droplink field".
		/// <returns><see cref="ILinkFieldWrapper"/></returns>
		/// </summary>
		public ILinkFieldWrapper DroplinkField => this.WrapField<ILinkFieldWrapper>(FieldNames.DroplinkField);
		
		/// <summary>
		/// A wrapped "Droplist" field for item field with name: "Droplist field".
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper DroplistField => this.WrapField<ITextFieldWrapper>(FieldNames.DroplistField);
		
		/// <summary>
		/// A wrapped "Droptree" field for item field with name: "Droptree field".
		/// <returns><see cref="ILinkFieldWrapper"/></returns>
		/// </summary>
		public ILinkFieldWrapper DroptreeField => this.WrapField<ILinkFieldWrapper>(FieldNames.DroptreeField);
		
		/// <summary>
		/// A wrapped "File" field for item field with name: "File field".
		/// <returns><see cref="IFileFieldWrapper"/></returns>
		/// </summary>
		public IFileFieldWrapper FileField => this.WrapField<IFileFieldWrapper>(FieldNames.FileField);
		
		/// <summary>
		/// A wrapped "General Link" field for item field with name: "General link field".
		/// <returns><see cref="IGeneralLinkFieldWrapper"/></returns>
		/// </summary>
		public IGeneralLinkFieldWrapper GeneralLinkField => this.WrapField<IGeneralLinkFieldWrapper>(FieldNames.GeneralLinkField);
		
		/// <summary>
		/// A wrapped "General Link with Search" field for item field with name: "General link with search field".
		/// <returns><see cref="IGeneralLinkFieldWrapper"/></returns>
		/// </summary>
		public IGeneralLinkFieldWrapper GeneralLinkWithSearchField => this.WrapField<IGeneralLinkFieldWrapper>(FieldNames.GeneralLinkWithSearchField);
		
		/// <summary>
		/// A wrapped "Grouped Droplink" field for item field with name: "Grouped droplink field".
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper GroupedDroplinkField => this.WrapField<ITextFieldWrapper>(FieldNames.GroupedDroplinkField);
		
		/// <summary>
		/// A wrapped "Grouped Droplist" field for item field with name: "Grouped droplist field".
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper GroupedDroplistField => this.WrapField<ITextFieldWrapper>(FieldNames.GroupedDroplistField);
		
		/// <summary>
		/// A wrapped "Image" field for item field with name: "Image field".
		/// <returns><see cref="IImageFieldWrapper"/></returns>
		/// </summary>
		public IImageFieldWrapper ImageField => this.WrapField<IImageFieldWrapper>(FieldNames.ImageField);
		
		/// <summary>
		/// A wrapped "Integer" field for item field with name: "Integer field".
		/// <returns><see cref="IIntegerFieldWrapper"/></returns>
		/// </summary>
		public IIntegerFieldWrapper IntegerField => this.WrapField<IIntegerFieldWrapper>(FieldNames.IntegerField);
		
		/// <summary>
		/// A wrapped "Multi-Line Text" field for item field with name: "Multi line text field".
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper MultiLineTextField => this.WrapField<ITextFieldWrapper>(FieldNames.MultiLineTextField);
		
		/// <summary>
		/// A wrapped "Multilist" field for item field with name: "Multilist field".
		/// <returns><see cref="IListFieldWrapper"/></returns>
		/// </summary>
		public IListFieldWrapper MultilistField => this.WrapField<IListFieldWrapper>(FieldNames.MultilistField);
		
		/// <summary>
		/// A wrapped "Multilist with Search" field for item field with name: "Multilist with search field".
		/// <returns><see cref="IListFieldWrapper"/></returns>
		/// </summary>
		public IListFieldWrapper MultilistWithSearchField => this.WrapField<IListFieldWrapper>(FieldNames.MultilistWithSearchField);
		
		/// <summary>
		/// A wrapped "Name Lookup Value List" field for item field with name: "Name valiue lookup field".
		/// <returns><see cref="INameLookupValueListFieldWrapper"/></returns>
		/// </summary>
		public INameLookupValueListFieldWrapper NameValiueLookupField => this.WrapField<INameLookupValueListFieldWrapper>(FieldNames.NameValiueLookupField);
		
		/// <summary>
		/// A wrapped "Name Value List" field for item field with name: "Name value list field".
		/// <returns><see cref="INameValueListFieldWrapper"/></returns>
		/// </summary>
		public INameValueListFieldWrapper NameValueListField => this.WrapField<INameValueListFieldWrapper>(FieldNames.NameValueListField);
		
		/// <summary>
		/// A wrapped "Number" field for item field with name: "Number field".
		/// <returns><see cref="INumberFieldWrapper"/></returns>
		/// </summary>
		public INumberFieldWrapper NumberField => this.WrapField<INumberFieldWrapper>(FieldNames.NumberField);
		
		/// <summary>
		/// A wrapped "Password" field for item field with name: "Password field".
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper PasswordField => this.WrapField<ITextFieldWrapper>(FieldNames.PasswordField);
		
		/// <summary>
		/// A wrapped "Rich Text" field for item field with name: "Rich text field".
		/// <returns><see cref="IRichTextFieldWrapper"/></returns>
		/// </summary>
		public IRichTextFieldWrapper RichTextField => this.WrapField<IRichTextFieldWrapper>(FieldNames.RichTextField);
		
		/// <summary>
		/// A wrapped "Single-Line Text" field for item field with name: "Single line text field".
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper SingleLineTextField => this.WrapField<ITextFieldWrapper>(FieldNames.SingleLineTextField);
		
		/// <summary>
		/// A wrapped "TreelistEx" field for item field with name: "Treelist ex field".
		/// <returns><see cref="IListFieldWrapper"/></returns>
		/// </summary>
		public IListFieldWrapper TreelistExField => this.WrapField<IListFieldWrapper>(FieldNames.TreelistExField);
		
		/// <summary>
		/// A wrapped "Treelist" field for item field with name: "Treelist field".
		/// <returns><see cref="IListFieldWrapper"/></returns>
		/// </summary>
		public IListFieldWrapper TreelistField => this.WrapField<IListFieldWrapper>(FieldNames.TreelistField);
		
		/// <summary>
		/// A wrapped "Version Identity" field for item field with name: "Version identity field".
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper VersionIdentityField => this.WrapField<ITextFieldWrapper>(FieldNames.VersionIdentityField);
		
		/// <summary>
		/// A wrapped "Version Link" field for item field with name: "Version link".
		/// <returns><see cref="ITextFieldWrapper"/></returns>
		/// </summary>
		public ITextFieldWrapper VersionLink => this.WrapField<ITextFieldWrapper>(FieldNames.VersionLink);
		
		public struct FieldNames
		{
			public const string CheckboxField = "Checkbox field";
			public const string ChecklistField = "Checklist field";
			public const string DateField = "Date field";
			public const string DateTimeField = "Date time field";
			public const string DroplinkField = "Droplink field";
			public const string DroplistField = "Droplist field";
			public const string DroptreeField = "Droptree field";
			public const string FileField = "File field";
			public const string GeneralLinkField = "General link field";
			public const string GeneralLinkWithSearchField = "General link with search field";
			public const string GroupedDroplinkField = "Grouped droplink field";
			public const string GroupedDroplistField = "Grouped droplist field";
			public const string ImageField = "Image field";
			public const string IntegerField = "Integer field";
			public const string MultiLineTextField = "Multi line text field";
			public const string MultilistField = "Multilist field";
			public const string MultilistWithSearchField = "Multilist with search field";
			public const string NameValiueLookupField = "Name valiue lookup field";
			public const string NameValueListField = "Name value list field";
			public const string NumberField = "Number field";
			public const string PasswordField = "Password field";
			public const string RichTextField = "Rich text field";
			public const string SingleLineTextField = "Single line text field";
			public const string TreelistExField = "Treelist ex field";
			public const string TreelistField = "Treelist field";
			public const string VersionIdentityField = "Version identity field";
			public const string VersionLink = "Version link";
		}

		public struct FieldIds
		{
			public static ID CheckboxField => new ID("{5C5ED316-191F-43F0-8C36-0ECC5FB7EC3F}");
			public static ID ChecklistField => new ID("{648E054C-118E-4D85-A411-B330982D8F6F}");
			public static ID DateField => new ID("{63FA7F24-844C-404D-9B97-A29BCC79EA0A}");
			public static ID DateTimeField => new ID("{B8709FD7-9E02-49E6-8F9F-BC8A2B0063EA}");
			public static ID DroplinkField => new ID("{98DA53F9-4548-4017-84F5-CBD352B9C311}");
			public static ID DroplistField => new ID("{338DED8E-AEA8-4B4D-8714-591A8777E215}");
			public static ID DroptreeField => new ID("{D5059E72-6F34-46E1-A116-162A0EDBBFF5}");
			public static ID FileField => new ID("{EADF091E-EDB4-4AB3-9E1E-E47200D0E1EB}");
			public static ID GeneralLinkField => new ID("{B0F91BB5-6724-4441-B8E2-249CE650791A}");
			public static ID GeneralLinkWithSearchField => new ID("{70CA1735-11B7-425F-B5EB-4B8476409F67}");
			public static ID GroupedDroplinkField => new ID("{D16362C9-B604-42A8-922F-846AD5522186}");
			public static ID GroupedDroplistField => new ID("{1CE14F49-BC02-4DF6-9D7C-26C13373740F}");
			public static ID ImageField => new ID("{ACB05B4D-DF67-4B24-B133-B2216438B309}");
			public static ID IntegerField => new ID("{8910745D-CA57-4C70-9335-FAAD2378DA7C}");
			public static ID MultiLineTextField => new ID("{D4AA5456-824C-42AD-9422-57A92475F185}");
			public static ID MultilistField => new ID("{1371CACA-CB3E-43A9-9945-7268A92B329E}");
			public static ID MultilistWithSearchField => new ID("{4E12B82F-5D40-4C24-B989-63160835BDB5}");
			public static ID NameValiueLookupField => new ID("{B47AC3CC-04AD-4995-8473-8EB1D6BAA25F}");
			public static ID NameValueListField => new ID("{861E4D85-68E7-4221-AD6A-1167063FF343}");
			public static ID NumberField => new ID("{19F6E2B4-4A44-4858-9CED-584BBD2A1647}");
			public static ID PasswordField => new ID("{08905761-E7D3-45C3-87E9-96A0FFCE912C}");
			public static ID RichTextField => new ID("{863BBB70-9559-4F52-8C52-AC52731A585B}");
			public static ID SingleLineTextField => new ID("{1F40B3CA-91B3-4C60-9C2B-B3E3325B5ECB}");
			public static ID TreelistExField => new ID("{F498D901-5042-4ADD-A9EA-2983CDA2741A}");
			public static ID TreelistField => new ID("{2D48AF11-3548-4E01-A48D-C2E9478E4066}");
			public static ID VersionIdentityField => new ID("{056B3AB1-36EA-441A-B24F-E074AA24FCAF}");
			public static ID VersionLink => new ID("{92910654-64FE-4EBE-AE50-D3DB86C217B0}");
		}
	}
}

#endregion


