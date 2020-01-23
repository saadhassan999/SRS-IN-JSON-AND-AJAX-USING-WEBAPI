using System;
using System.Reflection;

namespace SRS_IN_JSON_AND_AJAX_USING_WEAPI.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}