using System;

using R5T.L0069.T001;
using R5T.T0131;


namespace R5T.L0069
{
    [ValuesMarker]
    public partial interface IDocumentationTargets : IValuesMarker
    {
        /// <summary>
        /// Gets the <see cref="NoneDocumentationTarget"/> singleton instance.
        /// </summary>
        public NoneDocumentationTarget None => NoneDocumentationTarget.Instance;
    }
}
