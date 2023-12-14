using System;

using R5T.T0199.T000.Extensions;

using Instances = R5T.T0199.T000.Instances;


namespace R5T.N0003.Extensions
{
    public static class IntegerExtensions
    {
        /// <inheritdoc cref="IIntegerOperator.ToExclusiveIndex(int)"/>
        public static IExclusiveIndex ToExclusiveIndex(this int value)
        {
            return Instances.IntegerOperator_Extensions.ToExclusiveIndex(value);
        }

        /// <inheritdoc cref="IIntegerOperator.ToInclusiveIndex(int)"/>
        public static IInclusiveIndex ToInclusiveIndex(this int value)
        {
            return Instances.IntegerOperator_Extensions.ToInclusiveIndex(value);
        }

        public static IYear ToYear(this int value)
        {
            return Instances.IntegerOperator_Extensions.ToYear(value);
        }
    }
}
