using System;

using R5T.T0142;

using R5T.L0069.T000;


namespace R5T.L0069.T001
{
    /// <summary>
    /// A documentation target implementation for when there is no documentation target.
    /// Useful when handling documentation elements or other documentation content that is independent of a documentation target
    /// (such as a project file, or NuGet package).
    /// </summary>
    [DataTypeMarker]
    public class NoneDocumentationTarget : IDocumentationTarget
    {
        #region Static

        /// <summary>
        /// Singleton instance.
        /// </summary>
        public static readonly NoneDocumentationTarget Instance = new NoneDocumentationTarget()
        {
            Note = "Static Instance"
        };

        #endregion


        public string Note { get; set; }
    }
}
