using System;


namespace R5T.L0069
{
    public class DocumentationTargets : IDocumentationTargets
    {
        #region Infrastructure

        public static IDocumentationTargets Instance { get; } = new DocumentationTargets();


        private DocumentationTargets()
        {
        }

        #endregion
    }
}
