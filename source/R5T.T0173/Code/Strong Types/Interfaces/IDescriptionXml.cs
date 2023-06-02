using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0173
{
    /// <summary>
    /// A description in XML format.
    /// Useful for representing C# code XML documentation comments in their entirety.
    /// </summary>
    [StrongTypeMarker]
    public interface IDescriptionXml : ITyped<string>, IStrongTypeMarker
    {
    }
}
