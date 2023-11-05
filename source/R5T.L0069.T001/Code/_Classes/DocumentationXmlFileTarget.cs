using System;

using R5T.T0142;
using R5T.T0172;

using R5T.L0069.T000;


namespace R5T.L0069.T001
{
    /// <summary>
    /// Allows a documentation XML file to be a documentation target.
    /// </summary>
    [DataTypeMarker]
    public class DocumentationXmlFileTarget : IDocumentationTarget
    {
        public IDocumentationXmlFilePath DocumentationXmlFilePath { get; set; }


        public override string ToString()
        {
            var representation = this.DocumentationXmlFilePath.Value;
            return representation;
        }
    }
}
