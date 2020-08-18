// ReSharper Disable all
using global::Sitecore.Data;
using global::Sitecore.Data.Fields;
using global::Sitecore.Data.Items;
using global::System.CodeDom.Compiler;

namespace Sug.Foundation.SitecoreExtensions.Data
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ITestParametersTemplateItem
	{
		CheckboxField CheckboxFieldField { get; }
		ReferenceField DroplinkFieldField { get; }
		TextField IntegerFieldField { get; }
		InternalLinkField InternalLinkFieldField { get; }
		DelimitedField MultilistFieldField { get; }
		TextField NumberFieldField { get; }
		TextField SingleLineTextFieldField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class TestParametersTemplate : CustomItem, ITestParametersTemplateItem
	{
		public TestParametersTemplate(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Test parameters template";
		public static ID ItemTemplateId => new ID("{CB56320C-774A-4508-926F-4300E36C627C}");
		
		public CheckboxField CheckboxFieldField => new CheckboxField(InnerItem.Fields[FieldConstants.CheckboxField.Id]);
		public ReferenceField DroplinkFieldField => new ReferenceField(InnerItem.Fields[FieldConstants.DroplinkField.Id]);
		public TextField IntegerFieldField => new TextField(InnerItem.Fields[FieldConstants.IntegerField.Id]);
		public InternalLinkField InternalLinkFieldField => new InternalLinkField(InnerItem.Fields[FieldConstants.InternalLinkField.Id]);
		public DelimitedField MultilistFieldField => new DelimitedField(InnerItem.Fields[FieldConstants.MultilistField.Id], '|');
		public TextField NumberFieldField => new TextField(InnerItem.Fields[FieldConstants.NumberField.Id]);
		public TextField SingleLineTextFieldField => new TextField(InnerItem.Fields[FieldConstants.SingleLineTextField.Id]);
		public static implicit operator TestParametersTemplate(Item item) => item != null ? new TestParametersTemplate(item) : null;
		public static implicit operator Item(TestParametersTemplate customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct CheckboxField
            {
		        public const string FieldName = "Checkbox field";
		        public static readonly ID Id = new ID("{B8B91789-7070-4B44-8D52-7205BDFE8F7E}");
            }
            public struct DroplinkField
            {
		        public const string FieldName = "Droplink field";
		        public static readonly ID Id = new ID("{9FDA7450-8C77-493E-BEE7-C34DAF1D56EC}");
            }
            public struct IntegerField
            {
		        public const string FieldName = "Integer field";
		        public static readonly ID Id = new ID("{489831D2-6CA7-4A28-9B22-F0E05CC00461}");
            }
            public struct InternalLinkField
            {
		        public const string FieldName = "Internal link field";
		        public static readonly ID Id = new ID("{29C22D6E-B109-40C5-AC50-5043B3C289A4}");
            }
            public struct MultilistField
            {
		        public const string FieldName = "Multilist field";
		        public static readonly ID Id = new ID("{037F1EAD-F700-4024-A7A4-300002419A9F}");
            }
            public struct NumberField
            {
		        public const string FieldName = "Number field";
		        public static readonly ID Id = new ID("{800089F5-20F5-4401-BCEE-C188CD0F5BBE}");
            }
            public struct SingleLineTextField
            {
		        public const string FieldName = "Single line text field";
		        public static readonly ID Id = new ID("{B124C661-363F-4874-9F59-3D2FFB5E159E}");
            }
            
		}
	}
}

namespace Sug.Foundation.SitecoreExtensions.Data
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ITestTemplateItem
	{
		CheckboxField CheckboxFieldField { get; }
		ReferenceField ChecklistFieldField { get; }
		DateField DateFieldField { get; }
		DateField DateTimeFieldField { get; }
		ReferenceField DroplinkFieldField { get; }
		TextField DroplistFieldField { get; }
		ReferenceField DroptreeFieldField { get; }
		FileField FileFieldField { get; }
		LinkField GeneralLinkFieldField { get; }
		TextField GeneralLinkWithSearchFieldField { get; }
		ReferenceField GroupedDroplinkFieldField { get; }
		TextField GroupedDroplistFieldField { get; }
		ImageField ImageFieldField { get; }
		TextField IntegerFieldField { get; }
		TextField MultiLineTextFieldField { get; }
		DelimitedField MultilistFieldField { get; }
		TextField MultilistWithSearchFieldField { get; }
		TextField NameValiueLookupFieldField { get; }
		NameValueListField NameValueListFieldField { get; }
		TextField NumberFieldField { get; }
		TextField PasswordFieldField { get; }
		TextField RichTextFieldField { get; }
		TextField SingleLineTextFieldField { get; }
		DelimitedField TreelistExFieldField { get; }
		DelimitedField TreelistFieldField { get; }
		TextField VersionIdentityFieldField { get; }
		TextField VersionLinkField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class TestTemplate : CustomItem, ITestTemplateItem
	{
		public TestTemplate(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "Test template";
		public static ID ItemTemplateId => new ID("{8FFD86E6-F507-42C0-9B4B-8E9A0F782F46}");
		
		public CheckboxField CheckboxFieldField => new CheckboxField(InnerItem.Fields[FieldConstants.CheckboxField.Id]);
		public ReferenceField ChecklistFieldField => new ReferenceField(InnerItem.Fields[FieldConstants.ChecklistField.Id]);
		public DateField DateFieldField => new DateField(InnerItem.Fields[FieldConstants.DateField.Id]);
		public DateField DateTimeFieldField => new DateField(InnerItem.Fields[FieldConstants.DateTimeField.Id]);
		public ReferenceField DroplinkFieldField => new ReferenceField(InnerItem.Fields[FieldConstants.DroplinkField.Id]);
		public TextField DroplistFieldField => new TextField(InnerItem.Fields[FieldConstants.DroplistField.Id]);
		public ReferenceField DroptreeFieldField => new ReferenceField(InnerItem.Fields[FieldConstants.DroptreeField.Id]);
		public FileField FileFieldField => new FileField(InnerItem.Fields[FieldConstants.FileField.Id]);
		public LinkField GeneralLinkFieldField => new LinkField(InnerItem.Fields[FieldConstants.GeneralLinkField.Id]);
		public TextField GeneralLinkWithSearchFieldField => new TextField(InnerItem.Fields[FieldConstants.GeneralLinkWithSearchField.Id]);
		public ReferenceField GroupedDroplinkFieldField => new ReferenceField(InnerItem.Fields[FieldConstants.GroupedDroplinkField.Id]);
		public TextField GroupedDroplistFieldField => new TextField(InnerItem.Fields[FieldConstants.GroupedDroplistField.Id]);
		public ImageField ImageFieldField => new ImageField(InnerItem.Fields[FieldConstants.ImageField.Id]);
		public TextField IntegerFieldField => new TextField(InnerItem.Fields[FieldConstants.IntegerField.Id]);
		public TextField MultiLineTextFieldField => new TextField(InnerItem.Fields[FieldConstants.MultiLineTextField.Id]);
		public DelimitedField MultilistFieldField => new DelimitedField(InnerItem.Fields[FieldConstants.MultilistField.Id], '|');
		public TextField MultilistWithSearchFieldField => new TextField(InnerItem.Fields[FieldConstants.MultilistWithSearchField.Id]);
		public TextField NameValiueLookupFieldField => new TextField(InnerItem.Fields[FieldConstants.NameValiueLookupField.Id]);
		public NameValueListField NameValueListFieldField => new NameValueListField(InnerItem.Fields[FieldConstants.NameValueListField.Id]);
		public TextField NumberFieldField => new TextField(InnerItem.Fields[FieldConstants.NumberField.Id]);
		public TextField PasswordFieldField => new TextField(InnerItem.Fields[FieldConstants.PasswordField.Id]);
		public TextField RichTextFieldField => new TextField(InnerItem.Fields[FieldConstants.RichTextField.Id]);
		public TextField SingleLineTextFieldField => new TextField(InnerItem.Fields[FieldConstants.SingleLineTextField.Id]);
		public DelimitedField TreelistExFieldField => new DelimitedField(InnerItem.Fields[FieldConstants.TreelistExField.Id], '|');
		public DelimitedField TreelistFieldField => new DelimitedField(InnerItem.Fields[FieldConstants.TreelistField.Id], '|');
		public TextField VersionIdentityFieldField => new TextField(InnerItem.Fields[FieldConstants.VersionIdentityField.Id]);
		public TextField VersionLinkField => new TextField(InnerItem.Fields[FieldConstants.VersionLink.Id]);
		public static implicit operator TestTemplate(Item item) => item != null ? new TestTemplate(item) : null;
		public static implicit operator Item(TestTemplate customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct CheckboxField
            {
		        public const string FieldName = "Checkbox field";
		        public static readonly ID Id = new ID("{5C5ED316-191F-43F0-8C36-0ECC5FB7EC3F}");
            }
            public struct ChecklistField
            {
		        public const string FieldName = "Checklist field";
		        public static readonly ID Id = new ID("{648E054C-118E-4D85-A411-B330982D8F6F}");
            }
            public struct DateField
            {
		        public const string FieldName = "Date field";
		        public static readonly ID Id = new ID("{63FA7F24-844C-404D-9B97-A29BCC79EA0A}");
            }
            public struct DateTimeField
            {
		        public const string FieldName = "Date time field";
		        public static readonly ID Id = new ID("{B8709FD7-9E02-49E6-8F9F-BC8A2B0063EA}");
            }
            public struct DroplinkField
            {
		        public const string FieldName = "Droplink field";
		        public static readonly ID Id = new ID("{98DA53F9-4548-4017-84F5-CBD352B9C311}");
            }
            public struct DroplistField
            {
		        public const string FieldName = "Droplist field";
		        public static readonly ID Id = new ID("{338DED8E-AEA8-4B4D-8714-591A8777E215}");
            }
            public struct DroptreeField
            {
		        public const string FieldName = "Droptree field";
		        public static readonly ID Id = new ID("{D5059E72-6F34-46E1-A116-162A0EDBBFF5}");
            }
            public struct FileField
            {
		        public const string FieldName = "File field";
		        public static readonly ID Id = new ID("{EADF091E-EDB4-4AB3-9E1E-E47200D0E1EB}");
            }
            public struct GeneralLinkField
            {
		        public const string FieldName = "General link field";
		        public static readonly ID Id = new ID("{B0F91BB5-6724-4441-B8E2-249CE650791A}");
            }
            public struct GeneralLinkWithSearchField
            {
		        public const string FieldName = "General link with search field";
		        public static readonly ID Id = new ID("{70CA1735-11B7-425F-B5EB-4B8476409F67}");
            }
            public struct GroupedDroplinkField
            {
		        public const string FieldName = "Grouped droplink field";
		        public static readonly ID Id = new ID("{D16362C9-B604-42A8-922F-846AD5522186}");
            }
            public struct GroupedDroplistField
            {
		        public const string FieldName = "Grouped droplist field";
		        public static readonly ID Id = new ID("{1CE14F49-BC02-4DF6-9D7C-26C13373740F}");
            }
            public struct ImageField
            {
		        public const string FieldName = "Image field";
		        public static readonly ID Id = new ID("{ACB05B4D-DF67-4B24-B133-B2216438B309}");
            }
            public struct IntegerField
            {
		        public const string FieldName = "Integer field";
		        public static readonly ID Id = new ID("{8910745D-CA57-4C70-9335-FAAD2378DA7C}");
            }
            public struct MultiLineTextField
            {
		        public const string FieldName = "Multi line text field";
		        public static readonly ID Id = new ID("{D4AA5456-824C-42AD-9422-57A92475F185}");
            }
            public struct MultilistField
            {
		        public const string FieldName = "Multilist field";
		        public static readonly ID Id = new ID("{1371CACA-CB3E-43A9-9945-7268A92B329E}");
            }
            public struct MultilistWithSearchField
            {
		        public const string FieldName = "Multilist with search field";
		        public static readonly ID Id = new ID("{4E12B82F-5D40-4C24-B989-63160835BDB5}");
            }
            public struct NameValiueLookupField
            {
		        public const string FieldName = "Name valiue lookup field";
		        public static readonly ID Id = new ID("{B47AC3CC-04AD-4995-8473-8EB1D6BAA25F}");
            }
            public struct NameValueListField
            {
		        public const string FieldName = "Name value list field";
		        public static readonly ID Id = new ID("{861E4D85-68E7-4221-AD6A-1167063FF343}");
            }
            public struct NumberField
            {
		        public const string FieldName = "Number field";
		        public static readonly ID Id = new ID("{19F6E2B4-4A44-4858-9CED-584BBD2A1647}");
            }
            public struct PasswordField
            {
		        public const string FieldName = "Password field";
		        public static readonly ID Id = new ID("{08905761-E7D3-45C3-87E9-96A0FFCE912C}");
            }
            public struct RichTextField
            {
		        public const string FieldName = "Rich text field";
		        public static readonly ID Id = new ID("{863BBB70-9559-4F52-8C52-AC52731A585B}");
            }
            public struct SingleLineTextField
            {
		        public const string FieldName = "Single line text field";
		        public static readonly ID Id = new ID("{1F40B3CA-91B3-4C60-9C2B-B3E3325B5ECB}");
            }
            public struct TreelistExField
            {
		        public const string FieldName = "Treelist ex field";
		        public static readonly ID Id = new ID("{F498D901-5042-4ADD-A9EA-2983CDA2741A}");
            }
            public struct TreelistField
            {
		        public const string FieldName = "Treelist field";
		        public static readonly ID Id = new ID("{2D48AF11-3548-4E01-A48D-C2E9478E4066}");
            }
            public struct VersionIdentityField
            {
		        public const string FieldName = "Version identity field";
		        public static readonly ID Id = new ID("{056B3AB1-36EA-441A-B24F-E074AA24FCAF}");
            }
            public struct VersionLink
            {
		        public const string FieldName = "Version link";
		        public static readonly ID Id = new ID("{92910654-64FE-4EBE-AE50-D3DB86C217B0}");
            }
            
		}
	}
}

namespace Sug.Foundation.SitecoreExtensions.Data
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface ITestBaseTemplateItem
	{
		TextField BaseSingleLineTextFieldField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class TestBaseTemplate : CustomItem, ITestBaseTemplateItem
	{
		public TestBaseTemplate(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "_Test base template";
		public static ID ItemTemplateId => new ID("{B2DFC963-E803-488C-8102-30B4073BB865}");
		
		public TextField BaseSingleLineTextFieldField => new TextField(InnerItem.Fields[FieldConstants.BaseSingleLineTextField.Id]);
		public static implicit operator TestBaseTemplate(Item item) => item != null ? new TestBaseTemplate(item) : null;
		public static implicit operator Item(TestBaseTemplate customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct BaseSingleLineTextField
            {
		        public const string FieldName = "Base single line text field";
		        public static readonly ID Id = new ID("{781FB4A6-93D9-4723-9CAD-91E200DB3C9C}");
            }
            
		}
	}
}


