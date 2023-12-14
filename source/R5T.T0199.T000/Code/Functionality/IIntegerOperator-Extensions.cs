using System;

using R5T.N0003;

using R5T.T0132;


namespace R5T.T0199.T000.Extensions
{
    [FunctionalityMarker]
    public partial interface IIntegerOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IExclusiveIndex"/>
        public IExclusiveIndex ToExclusiveIndex(int value)
        {
            var output = new ExclusiveIndex(value);
            return output;
        }

        /// <inheritdoc cref="IInclusiveIndex"/>
        public IInclusiveIndex ToInclusiveIndex(int value)
        {
            var output = new InclusiveIndex(value);
            return output;
        }

        public IYear ToYear(int value)
        {
            var output = new Year(value);
            return output;
        }
    }
}
