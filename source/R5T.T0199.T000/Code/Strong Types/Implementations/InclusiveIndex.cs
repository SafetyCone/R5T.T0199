using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.N0003
{
    /// <inheritdoc cref="IInclusiveIndex"/>
    [StrongTypeImplementationMarker]
    public class InclusiveIndex : TypedBase<int>, IStrongTypeMarker,
        IInclusiveIndex
    {
        public InclusiveIndex(int value)
            : base(value)
        {
        }
    }
}