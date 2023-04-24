using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0173
{
    /// <inheritdoc cref="IDescriptionXml"/>
    [StrongTypeImplementationMarker]
    public class DescriptionXml : TypedBase<string>, IStrongTypeMarker,
        IDescriptionXml
    {
        public DescriptionXml(string value)
            : base(value)
        {
        }
    }
}
