using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Caching;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;
using System.Xml;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Sug.Foundation.SitecoreExtensions.Extensions
{
	using Sitecore.Mvc.Helpers;
	using Sitecore.DependencyInjection;

	public static class SitecoreHelperExtensions
  {
    public static bool IsExperienceEditor(this SitecoreHelper helper)
    {
      return Sitecore.Context.PageMode.IsExperienceEditor || Sitecore.Context.PageMode.IsExperienceEditorEditing;
    }
  }
}