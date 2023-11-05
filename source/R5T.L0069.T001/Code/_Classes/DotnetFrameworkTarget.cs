using System;

using R5T.T0142;
using R5T.T0218;

using R5T.L0069.T000;


namespace R5T.L0069.T001
{
    /// <summary>
    /// Represents a .NET framework (core, standard, or otherwise) target.
    /// For example, .NET Standard 2.1 is a target or, 
    /// </summary>
    [DataTypeMarker]
    public class DotnetFrameworkTarget : IDocumentationTarget
    {
        public ITargetFrameworkMoniker TargetFrameworkMoniker { get; set; }
    }
}
