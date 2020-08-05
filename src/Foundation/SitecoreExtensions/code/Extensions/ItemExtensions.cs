namespace Sug.Foundation.SitecoreExtensions.Extensions
{
	using System;
	using Sitecore.Data;
	using Sitecore.Data.Items;
	using Sitecore.Data.Managers;
	using Sitecore.Links;
	using Sitecore.Globalization;
	//using Xwrap;

	public static class ItemExtensions
	{
		//public static string GenerateUrl<TWrapper>(this TWrapper item, bool absolute = false)
		//	where TWrapper : ItemWrapper
		//{
		//	return item.OriginalItem.GenerateUrl(absolute);
		//}

		public static string GenerateUrl(this Item item, bool absolute = false)
		{
			if (item == null) throw new ArgumentNullException(nameof(item));
			var options = LinkManager.GetDefaultUrlBuilderOptions();

			if (absolute)
			{
				options.AlwaysIncludeServerUrl = true;
			}

			using (new LanguageSwitcher(item.Language))
			{
				return LinkManager.GetItemUrl(item, options);
			}
		}
		
		public static bool IsDerived(this Item item, Guid templateId)
		{
			if (item == null) return false;

			return item.IsDerived(new ID(templateId));
		}

		public static bool IsDerived(this Item item, ID templateId)
		{
			if (item == null)
			{
				return false;
			}

			return !templateId.IsNull && item.IsDerived(item.Database.Templates[templateId]);
		}

		private static bool IsDerived(this Item item, Item templateItem)
		{
			if (item == null)
			{
				return false;
			}

			if (templateItem == null)
			{
				return false;
			}

			var itemTemplate = TemplateManager.GetTemplate(item);
			return itemTemplate != null && (itemTemplate.ID == templateItem.ID || itemTemplate.DescendsFrom(templateItem.ID));
		}
	}
}