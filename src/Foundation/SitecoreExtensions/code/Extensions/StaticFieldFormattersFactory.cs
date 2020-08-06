using System.Collections.Generic;
using System.IO;
using Sitecore.Abstractions.Serialization;
using Sitecore.Data.Serialization.Yaml;
using Sitecore.Data.Serialization.Yaml.Formatting;
using Sug.Foundation.SitecoreExtensions.Extensions;

namespace Sug.Foundation.SitecoreExtensions.Extensions
{
	using System.Collections.Generic;
	using Sitecore.Data.Serialization.Yaml.Formatting;

	public class StaticFieldFormattersFactory : Sitecore.Data.Serialization.Yaml.Formatting.FieldFormattersFactory
	{
		private readonly IEnumerable<BaseFieldFormatter> formatters;

		public StaticFieldFormattersFactory(IEnumerable<BaseFieldFormatter> formatters)
			:base(new MockedFactory())
		{
			this.formatters = formatters;
		}

		public override IEnumerable<BaseFieldFormatter> Create()
		{
			return this.formatters;
		}
	}
}



public class Foo
{


	public void Bar()
	{
		//var files = Configurations.SelectMany(x => Directory.EnumerateFiles(x, "*.yml", SearchOption.AllDirectories));

		//var items = new List<IItemData>();

		//var formatters = new BaseFieldFormatter[]
		//{
		//	new Sitecore.Data.Serialization.Yaml.Formatting.XmlFieldFormatter(),
		//	new Sitecore.Data.Serialization.Yaml.Formatting.MultilistFormatter(),
		//	new Sitecore.Data.Serialization.Yaml.Formatting.CheckboxFieldFormatter()
		//};

	

		//var factory = new StaticFieldFormattersFactory(formatters);
		//var serializer = new YamlItemSerializer(factory);
		//foreach (var file in files)
		//{
			
		//	using (System.IO.TextReader reader = new StreamReader(file))
		//	{
		//		var item = serializer.Read(reader);
		//	}
		//}
	}
}