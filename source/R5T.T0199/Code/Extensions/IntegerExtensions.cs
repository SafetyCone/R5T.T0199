using System;


namespace R5T.T0199.Extensions
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
    }
}
