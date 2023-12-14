using System;

using R5T.N0003;

using R5T.T0132;


namespace R5T.T0199.T001.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public ICompanyName ToCompanyName(string value)
        {
            var output = new CompanyName(value);
            return output;
        }

        public IDescription ToDescription(string value)
        {
            var output = new Description(value);
            return output;
        }
    }
}
