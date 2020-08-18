// ReSharper Disable all
using global::Sitecore.Data;
using global::Sitecore.Data.Fields;
using global::Sitecore.Data.Items;
using global::System.CodeDom.Compiler;

namespace Sug.Feature.Metadata
{
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public interface IMetadataItem
	{
		TextField MetaTitleField { get; }
	}
	[GeneratedCode("Leprechaun", "2.0.0.0")]
	public class Metadata : CustomItem, IMetadataItem
	{
		public Metadata(Item innerItem)
			:base(innerItem)
		{
		}
		public static string TemplateName => "_Metadata";
		public static ID ItemTemplateId => new ID("{1F082A45-36F5-4DE1-988A-72AAC08BD330}");
		
		public TextField MetaTitleField => new TextField(InnerItem.Fields[FieldConstants.MetaTitle.Id]);
		public static implicit operator Metadata(Item item) => item != null ? new Metadata(item) : null;
		public static implicit operator Item(Metadata customItem) => customItem?.InnerItem;
		public struct FieldConstants
		{
			public struct MetaTitle
            {
		        public const string FieldName = "Meta title";
		        public static readonly ID Id = new ID("{AB300DB7-3D19-4E2F-BF52-4BF0B892ABC2}");
            }
            
		}
	}
}


