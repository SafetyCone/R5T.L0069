using System;

using R5T.T0132;
using R5T.T0172;
using R5T.T0218;

using R5T.L0069.T000;
using R5T.L0069.T001;


namespace R5T.L0069
{
    [FunctionalityMarker]
    public partial interface IDocumentationTargetOperator : IFunctionalityMarker
    {
        public DocumentationXmlFileTarget Get_DocumentationXmlFileTarget(IDocumentationXmlFilePath documentationXmlFilePath)
        {
            var output = new DocumentationXmlFileTarget()
            {
                DocumentationXmlFilePath = documentationXmlFilePath,
            };

            return output;
        }

        public DotnetFrameworkTarget Get_DotnetFrameworkTarget(ITargetFrameworkMoniker targetFrameworkMoniker)
        {
            var dotnetFrameworkTarget = new DotnetFrameworkTarget
            {
                TargetFrameworkMoniker = targetFrameworkMoniker,
            };

            return dotnetFrameworkTarget;
        }

        public string Describe(IDocumentationTarget documentationTarget)
        {
            var output = documentationTarget switch
            {
                ProjectDocumentationTarget projectDocumentationTarget => this.Describe_Project(projectDocumentationTarget),
                _ => this.Describe_UnknownType(documentationTarget)
            };

            return output;
        }

        public string Describe_UnknownType(IDocumentationTarget documentationTarget)
        {
            var documentationTargetTypeName = Instances.TypeNameOperator.Get_TypeNameOf(documentationTarget);

            var output = $"{documentationTargetTypeName}: unknown documentation target type";
            return output;
        }

        public string Describe_Project(ProjectDocumentationTarget documentationTarget)
        {
            var output = documentationTarget.ProjectFilePath.Value;
            return output;
        }
    }
}
