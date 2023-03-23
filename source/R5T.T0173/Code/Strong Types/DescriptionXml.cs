using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0173
{
    /// <summary>
    /// A description in XML format.
    /// </summary>
    [StrongTypeMarker]
    public class DescriptionXml : TypedString, IStrongTypeMarker
    {
        public DescriptionXml(string value)
            : base(value)
        {
        }
    }
}
