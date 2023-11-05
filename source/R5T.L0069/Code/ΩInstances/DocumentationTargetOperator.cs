using System;


namespace R5T.L0069
{
    public class DocumentationTargetOperator : IDocumentationTargetOperator
    {
        #region Infrastructure

        public static IDocumentationTargetOperator Instance { get; } = new DocumentationTargetOperator();


        private DocumentationTargetOperator()
        {
        }

        #endregion
    }
}
