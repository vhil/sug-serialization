using System;
using System.Linq;
using System.Text;

Log.Debug($"Emitting templates for {ConfigurationName}...");

public string RenderTemplates()
{
	var localCode = new System.Text.StringBuilder();

	foreach (var template in Templates)
	{
		if (IsRenderingParameters(template))
		{
			localCode.AppendLine($@"
namespace {ConfigurationName}.SitecoreTemplates
{{
	/// <summary>
	/// Rendering parameters wrapper for template '{template.Name}'.
	/// Template ID: {template.Id.ToString("B").ToUpper()}.
	/// Template path: {template.Path}.
	/// </summary>
	[GeneratedCode(""Leprechaun"", ""2.0.1"")]
	public partial class {template.CodeName} : RenderingParametersWrapper
	{{
		public {template.CodeName}(RenderingParameters parameters) : base(parameters)
		{{
		}}
		{RenderParametersFields(template)}
		public struct FieldNames
		{{{RenderFieldNames(template)}
		}}
	}}
}}");
		}
		else
		{
			localCode.AppendLine($@"
namespace {ConfigurationName}.SitecoreTemplates
{{
    /// <summary>
	/// Item wrapper for items of template '{template.Name}'.
	/// Template ID: {template.Id.ToString("B").ToUpper()}.
	/// Template path: {template.Path}.
	/// </summary>
	[GeneratedCode(""Leprechaun"", ""2.0.1"")]
    [TemplateId(Constants.TemplateIdString)]
    // ReSharper disable once InconsistentNaming
	// ReSharper disable once PartialTypeWithSinglePart
	public partial class {template.CodeName}Item : ItemWrapper
	{{
		public {template.CodeName}Item(Item item) : base(item)
		{{
		}}

		public static class Constants
		{{
			public static readonly TemplateID TemplateId = new TemplateID(new ID(TemplateIdString));
			public const string TemplateIdString = ""{template.Id.ToString("B").ToUpper()}""; 
		}}
		{RenderItemFields(template)}
		public struct FieldNames
		{{{RenderFieldNames(template)}
		}}

		public struct FieldIds
		{{{RenderFieldIds(template)}
		}}
	}}
}}");
		}
	}

	return localCode.ToString();
}

Code.AppendLine($@"// Auto-generated xWrap item wrappers for {ConfigurationName} configuration
using global::Sitecore.Data;
using global::Sitecore.Data.Items;
using global::Sitecore.Mvc.Presentation;
using global::System.CodeDom.Compiler;
using global::Xwrap;
using global::Xwrap.FieldWrappers.Abstractions;
using global::Xwrap.Mvc.RenderingParameters;

{RenderTemplates()}
");

public bool IsRenderingParameters(TemplateCodeGenerationMetadata template)
{
	if (template.BaseTemplates.Any())
	{
		Log.Debug($"Base templates for {template.Name} are: {string.Join(", ", template.BaseTemplates.Select(x => x.Name))}");
	}
	else
	{
		Log.Debug($"No base templates found for template {template.Name}");
	}

	return template.BaseTemplates.Any(x => x.Id == new Guid("{8CA06D6A-B353-44E8-BC31-B528C7306971}"));
}

public string RenderFieldNames(TemplateCodeGenerationMetadata template)
{
	var localCode = new StringBuilder();

	foreach (var field in template.OwnFields)
	{
		localCode.Append($@"
			public const string {field.CodeName} = ""{field.Name}"";");
	}

	return localCode.ToString();
}

public string RenderFieldIds(TemplateCodeGenerationMetadata template)
{
	var localCode = new StringBuilder();

	foreach (var field in template.OwnFields)
	{
		localCode.Append($@"
			public static ID {field.CodeName} => new ID(""{field.Id.ToString("B").ToUpper()}"");");
	}

	return localCode.ToString();
}

public string RenderItemFields(TemplateCodeGenerationMetadata template)
{
	var localCode = new StringBuilder();

	foreach (var field in template.OwnFields)
	{
		localCode.Append($@"
		/// <summary>
		/// A wrapped ""{field.Type}"" field for item field with name: ""{field.Name}"".
		/// <returns><see cref=""{GetFieldWrapperType(field)}""/></returns>
		/// </summary>
		public {GetFieldWrapperType(field)} {field.CodeName} => this.WrapField<{GetFieldWrapperType(field)}>(FieldNames.{field.CodeName});
		");
	}
	
	return localCode.ToString();
}

public string RenderParametersFields(TemplateCodeGenerationMetadata template)
{
	var localCode = new StringBuilder();

	foreach (var field in template.OwnFields)
	{
		localCode.Append($@"
		/// <summary>
		/// A wrapped ""{field.Type}"" parameter for field with name ""{field.Name}"".
		/// <returns><see cref=""{GetParameterWrapperType(field)}""/></returns>
		/// </summary>
		public {GetParameterWrapperType(field)} {field.CodeName} => this.{GetParameterMethodName(field)}(FieldNames.{field.CodeName});
		");
	}

return localCode.ToString();
}

public string GetFieldWrapperType(TemplateFieldCodeGenerationMetadata field)
{
	string returnType = string.Empty;

	switch (field.Type.ToLowerInvariant())
	{
		case "checkbox":
			returnType = "ICheckboxFieldWrapper";
			break;
		case "image":
			returnType = "IImageFieldWrapper";
			break;
		case "file":
			returnType = "IFileFieldWrapper";
			break;
		case "date":
		case "datetime":
			returnType = "IDateTimeFieldWrapper";
			break;
		case "checklist":
		case "treelist":
		case "treelist with search":
		case "treelistex":
		case "multilist":
		case "multilist with search":
		case "multi-root treelist":
		case "accounts multilist":
		case "tags":
			returnType = "IListFieldWrapper";
			break;
		case "droplink":
		case "lui component theme":
		case "droptree":
			returnType = "ILinkFieldWrapper";
			break;
		case "internal link":
			returnType = "IInternalLinkFieldWrapper";
			break;
		case "general link":
		case "general link with search":
			returnType = "IGeneralLinkFieldWrapper";
			break;
		case "text":
		case "single-line text":
		case "multi-line text":
			returnType = "ITextFieldWrapper";
			break;
		case "rich text":
			returnType = "IRichTextFieldWrapper";
			break;
		case "number":
			returnType = "INumberFieldWrapper";
			break;
		case "integer":
			returnType = "IIntegerFieldWrapper";
			break;
		case "name lookup value list":
			returnType = "INameLookupValueListFieldWrapper";
			break;
		case "name value list":
			returnType = "INameValueListFieldWrapper";
			break;
		default:
			returnType = "ITextFieldWrapper";
			break;
	}

	return returnType;
}

public string GetParameterWrapperType(TemplateFieldCodeGenerationMetadata field)
{
	string returnType = string.Empty;
	switch (field.Type.ToLowerInvariant())
	{
		case "checkbox":
			returnType = "ICheckboxFieldWrapper";
			break;
		case "checklist":
		case "treelist":
		case "treelist with search":
		case "treelistex":
		case "multilist":
		case "multilist with search":
		case "multi-root treelist":
		case "accounts multilist":
		case "tags":
			returnType = "IListFieldWrapper";
			break;
		case "droplink":
		case "droptree":
		case "lui component theme":
			returnType = "ILinkFieldWrapper";
			break;
		case "internal link":
			returnType = "IInternalLinkFieldWrapper";
			break;
		case "text":
		case "single-line text":
		case "multi-line text":
			returnType = "ITextFieldWrapper";
			break;
		case "number":
			returnType = "INumberFieldWrapper";
			break;
		case "integer":
			returnType = "IIntegerFieldWrapper";
			break;
		default:
			returnType = "ITextFieldWrapper";
			break;
	}

	return returnType;
}

public string GetParameterMethodName(TemplateFieldCodeGenerationMetadata field)
{
	var fieldWrapperName = GetParameterWrapperType(field);
	fieldWrapperName = fieldWrapperName.Substring(1, fieldWrapperName.Length - 1);
	return fieldWrapperName.Replace("Wrapper", "");
}