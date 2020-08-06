namespace Sug.Foundation.SitecoreExtensions.Extensions
{
	public class MockedFactory : Sitecore.Abstractions.BaseFactory
	{
		public override Sitecore.Web.UI.WebControls.ErrorControl CreateErrorControl(string message, string details)
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Xml.XPath.ItemNavigator CreateItemNavigator(Sitecore.Data.Items.Item item)
		{
			throw new System.NotImplementedException();
		}

		public override T CreateObject<T>(System.Xml.XmlNode configNode)
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Configuration.ConfigStore GetConfigStore(string configStoreName)
		{
			throw new System.NotImplementedException();
		}

		public override System.Collections.Generic.List<Sitecore.Web.CustomHandler> GetCustomHandlers()
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Data.Database GetDatabase(string name)
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Data.Database GetDatabase(string name, bool assert)
		{
			throw new System.NotImplementedException();
		}

		public override string[] GetDatabaseNames()
		{
			throw new System.NotImplementedException();
		}

		public override System.Collections.Generic.List<Sitecore.Data.Database> GetDatabases()
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Collections.StringDictionary GetDomainMap(string path)
		{
			throw new System.NotImplementedException();
		}

		public override System.Collections.Hashtable GetHashtable(string path, Sitecore.Configuration.Factory.HashKeyType keyType, Sitecore.Configuration.Factory.HashValueType valueType, Sitecore.Configuration.Factory.HashValueFormat format,
			System.Type dataType)
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Data.IDTables.IDTableProvider GetIDTable()
		{
			throw new System.NotImplementedException();
		}

		public override System.Collections.Generic.IComparer<Sitecore.Data.Items.Item> GetItemComparer(Sitecore.Data.Items.Item item)
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Links.LinkDatabase GetLinkDatabase()
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Data.MasterVariablesReplacer GetMasterVariablesReplacer()
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Collections.PerformanceCounterCollection GetPerformanceCounters()
		{
			throw new System.NotImplementedException();
		}

		public override TCollection GetProviders<TProvider, TCollection>(string rootPath, out TProvider defaultProvider)
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Data.DataProviders.IRetryable GetRetryer()
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Text.Replacer GetReplacer(string name)
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Sites.SiteContext GetSite(string siteName)
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Web.SiteInfo GetSiteInfo(string siteName)
		{
			throw new System.NotImplementedException();
		}

		public override System.Collections.Generic.List<Sitecore.Web.SiteInfo> GetSiteInfoList()
		{
			throw new System.NotImplementedException();
		}

		public override string[] GetSiteNames()
		{
			throw new System.NotImplementedException();
		}

		public override string GetString(string configPath, bool assert)
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Collections.Set<string> GetStringSet(string configPath)
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Tasks.TaskDatabase GetArchiveTaskDatabase()
		{
			throw new System.NotImplementedException();
		}

		public override Sitecore.Tasks.TaskDatabase GetTaskDatabase()
		{
			throw new System.NotImplementedException();
		}

		public override object CreateObject(string configPath, bool assert)
		{
			throw new System.NotImplementedException();
		}

		public override object CreateObject(string configPath, string[] parameters, bool assert)
		{
			throw new System.NotImplementedException();
		}

		public override object CreateObject(System.Xml.XmlNode configNode, bool assert)
		{
			throw new System.NotImplementedException();
		}

		public override object CreateObject(System.Xml.XmlNode configNode, string[] parameters, bool assert)
		{
			throw new System.NotImplementedException();
		}

		public override object CreateObject(System.Xml.XmlNode configNode, string[] parameters, bool assert, Sitecore.Configuration.IFactoryHelper helper)
		{
			throw new System.NotImplementedException();
		}

		public override System.Type CreateType(System.Xml.XmlNode configNode, bool assert)
		{
			throw new System.NotImplementedException();
		}

		public override System.Type CreateType(System.Xml.XmlNode configNode, string[] parameters, bool assert)
		{
			throw new System.NotImplementedException();
		}

		public override System.Type FindType(string className, System.Reflection.Assembly assembly)
		{
			throw new System.NotImplementedException();
		}

		public override string GetAttribute(string name, System.Xml.XmlNode node, string[] parameters)
		{
			throw new System.NotImplementedException();
		}

		public override System.Xml.XmlNode GetConfigNode(string xpath)
		{
			throw new System.NotImplementedException();
		}

		public override System.Xml.XmlNode GetConfigNode(string xpath, bool assert)
		{
			throw new System.NotImplementedException();
		}

		public override System.Xml.XmlNodeList GetConfigNodes(string xpath)
		{
			throw new System.NotImplementedException();
		}

		public override void Reset()
		{
			throw new System.NotImplementedException();
		}

		public override System.Xml.XmlDocument GetConfiguration()
		{
			throw new System.NotImplementedException();
		}
	}
}