using System;

using R5T.T0132;


namespace R5T.T0173
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public DescriptionXml ToDescriptionXml(string value)
        {
            var output = new DescriptionXml(value);
            return output;
        }
    }
}
