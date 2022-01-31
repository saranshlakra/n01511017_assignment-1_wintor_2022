using System;
using System.Reflection;

namespace n01511017_assignment_1_wintor_2022.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}