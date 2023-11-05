using System;

using R5T.T0142;
using R5T.T0172;

using R5T.L0069.T000;


namespace R5T.L0069.T001
{
    /// <summary>
    /// Allows a project to be a documentation target.
    /// </summary>
    [DataTypeMarker]
    public class ProjectDocumentationTarget : IDocumentationTarget
    {
        public IProjectFilePath ProjectFilePath { get; set; }
    }
}
